using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace blzZmq1.Services
{
    public class MonicaIO
    {

        //dynamic dyn;


        //protected override void ReadJsons()
        // {
        //   dyn = JsonConvert.DeserializeObject(json_sim);
        // ... read the rest
        // }

/*
        public static int OP_AVG = 0;
        public static int OP_MEDIAN = 1;
        public static int OP_SUM = 2;
        public static int OP_MIN = 3;
        public static int OP_MAX = 4;
        public static int OP_FIRST = 5;
        public static int OP_LAST = 6;
        public static int OP_NONE = 7;
        public static int OP_UNDEFINED_OP_ = 8;
        public static int ORGAN_ROOT = 0;
        public static int ORGAN_LEAF = 1;
        public static int ORGAN_SHOOT = 2;
        public static int ORGAN_FRUIT = 3;
        public static int ORGAN_STRUCT = 4;
        public static int ORGAN_SUGAR = 5;
        public static int ORGAN_UNDEFINED_ORGAN_ = 6;
        public static bool oid_is_organ(string oid)
        {
            return oid["organ"] != ORGAN_UNDEFINED_ORGAN_;
        }

        public static bool oid_is_range(string oid)
        {
            return oid["fromLayer"] >= 0 && oid["toLayer"] >= 0;
            //and oid["fromLayer"] < oid["toLayer"]
        }

        public static string op_to_string(int op)
        {
            return new Dictionary<int, string> {
            {
                OP_AVG,
                "AVG"},
            {
                OP_MEDIAN,
                "MEDIAN"},
            {
                OP_SUM,
                "SUM"},
            {
                OP_MIN,
                "MIN"},
            {
                OP_MAX,
                "MAX"},
            {
                OP_FIRST,
                "FIRST"},
            {
                OP_LAST,
                "LAST"},
            {
                OP_NONE,
                "NONE"},
            {
                OP_UNDEFINED_OP_,
                "undef"}}.TryGetValue(op, "undef");
        }

        public static string organ_to_string(int organ)
        {
            return new Dictionary<int, string> {
            {
                ORGAN_ROOT,
                "Root"},
            {
                ORGAN_LEAF,
                "Leaf"},
            {
                ORGAN_SHOOT,
                "Shoot"},
            {
                ORGAN_FRUIT,
                "Fruit"},
            {
                ORGAN_STRUCT,
                "Struct"},
            {
                ORGAN_SUGAR,
                "Sugar"},
            {
                ORGAN_UNDEFINED_ORGAN_,
                "undef"}}.get(organ, "undef");
        }

        public static string oid_to_string(string oid, bool include_time_agg)
        {
            var oss = "";
            oss += "[";
            oss += oid["name"];
            if (oid_is_organ(oid))
            {
                oss += ", " + organ_to_string(oid["organ"]);
            }
            else if (oid_is_range(oid))
            {
                oss += ", [" + ToString(oid["fromLayer"] + 1) + ", " + ToString(oid["toLayer"] + 1) + oid["layerAggOp"] != OP_NONE ? ", " + op_to_string(oid["layerAggOp"]) : "" + "]";
            }
            else if (oid["fromLayer"] >= 0)
            {
                oss += ", " + ToString(oid["fromLayer"] + 1);
            }
            if (include_time_agg)
            {
                oss += ", " + op_to_string(oid["timeAggOp"]);
            }
            oss += "]";
            return oss;
        }

        // write header rows
        public static object write_output_header_rows(string[] output_ids, bool include_header_row = true, bool include_units_row = true, bool include_time_agg = false)
        {
            var row1 = new List<object>();
            var row2 = new List<object>();
            var row3 = new List<object>();
            var row4 = new List<object>();
            foreach (var oid in output_ids)
            {
                int from_layer = oid["fromLayer"];
                int to_layer = oid["toLayer"];
                var is_organ = oid_is_organ(oid);
                var is_range = oid_is_range(oid) && oid["layerAggOp"] == OP_NONE;
                if (is_organ)
                {
                    // organ is being represented just by the value of fromLayer currently
                    to_layer = oid["organ"];
                }
                else if (is_range)
                {
                    from_layer += 1;
                    to_layer += 1;
                }
                else
                {
                    to_layer = from_layer;
                }
                for (int i = from_layer; i <= to_layer; i++ )
                //foreach (var i in range(from_layer, to_layer + 1))
                {
                    var str1 = "";
                    if (is_organ)
                    {
                        str1 += oid["displayName"].Count == 0 ? oid["name"] + "/" + organ_to_string(oid["organ"]) : oid["displayName"];
                    }
                    else if (is_range)
                    {
                        str1 += oid["displayName"].Count == 0 ? oid["name"] + "_" + ToString(i) : oid["displayName"];
                    }
                    else
                    {
                        str1 += oid["displayName"].Count == 0 ? oid["name"] : oid["displayName"];
                    }
                    row1.Add(str1);
                    row4.Add("j:" + oid["jsonInput"].replace("\"", ""));
                    row3.Add("m:" + oid_to_string(oid, include_time_agg));
                    row2.Add("[" + oid["unit"] + "]");
                }
            }
            var @out = new List<object>();
            if (include_header_row)
            {
                @out.Add(row1);
            }
            if (include_units_row)
            {
                @out.Add(row4);
            }
            if (include_time_agg)
            {
                @out.Add(row3);
                @out.Add(row2);
            }
            return @out;
        }

        // write actual output lines
        public static object write_output(string[] output_ids, string[] values)
        {
            var @out = new List<string>();
            if (values.Count() > 0)
            {
                for (int k = 0; k < values[0].Count() ; k++ )
                //foreach (var k in range(0, values[0].Count))
                {
                    var i = 0;
                    var row = new List<string>();
                    foreach (var _ in output_ids)
                    {
                        var @j__ = values[i][k];
                        if (@j__ is list)
                        {
                            foreach (var jv_ in @j__)
                            {
                                row.Add(jv_);
                            }
                        }
                        else
                        {
                            row.Add(@j__);
                        }
                        i += 1;
                    }
                    @out.Add(row);
                }
            }
            return @out;
        }

        // is absolute path
        public static object is_absolute_path(object p)
        {
            return p.startswith("/") || p.Count == 2 && p[1] == ":" || p.Count > 2 && p[1] == ":" && (p[2] == "\\" || p[2] == "/");
        }

        // fix system separator
        public static object fix_system_separator(object path)
        {
            path = path.replace("\\", "/");
            var new_path = path;
            while (true)
            {
                new_path = path.replace("//", "/");
                if (new_path == path)
                {
                    break;
                }
                path = new_path;
            }
            return new_path;
        }

        // replace ${ENV_VAR} in path
        public static object replace_env_vars(object path)
        {
            var start_token = "${";
            var end_token = "}";
            var start_pos = path.find(start_token);
            while (start_pos > -1)
            {
                var end_pos = path.find(end_token, start_pos + 1);
                if (end_pos > -1)
                {
                    var name_start = start_pos + 2;
                    var env_var_name = path[name_start::end_pos];
                    var env_var_content = os.environ.get(env_var_name, null);
                    if (env_var_content)
                    {
                        path = path.replace(path[start_pos::(end_pos + 1)], env_var_content);
                        start_pos = path.find(start_token);
                    }
                    else
                    {
                        start_pos = path.find(start_token, end_pos + 1);
                    }
                }
                else
                {
                    break;
                }
            }
            return path;
        }

        // return default value if key not there
        public static object default_value(object dic, object key, object @default)
        {
            return dic.Contains(key) ? dic[key] : @default;
        }

        public static object read_and_parse_json_file(object path)
        {
            using (var f = open(path))
            {
                return new Dictionary<object, object> {
                {
                    "result",
                    json.load(f)},
                {
                    "errors",
                    new List<object>()},
                {
                    "success",
                    true}};
            }
            return new Dictionary<object, object> {
            {
                "result",
                new Dictionary<object, object> {
                }},
            {
                "errors",
                new List<object> {
                    "Error opening file with path : '" + path + "'!"
                }},
            {
                "success",
                false}};
        }

        public static object parse_json_string(object jsonString)
        {
            return new Dictionary<object, object> {
            {
                "result",
                json.loads(jsonString)},
            {
                "errors",
                new List<object>()},
            {
                "success",
                true}};
        }

        public static object is_string_type(object j)
        {
            return j is str;
        }

        public static object find_and_replace_references(object root, object j)
        {
            object res;
            var sp = supported_patterns();
            var success = true;
            var errors = new List<object>();
            if (j is list && j.Count > 0)
            {
                var arr = new List<object>();
                var array_is_reference_function = false;
                if (is_string_type(j[0]))
                {
                    if (sp.Contains(j[0]))
                    {
                        var f = sp[j[0]];
                        array_is_reference_function = true;
                        //check for nested function invocations in the arguments
                        var funcArr = new List<object>();
                        foreach (var i in j)
                        {
                            res = find_and_replace_references(root, i);
                            success = success && res["success"];
                            if (!res["success"])
                            {
                                foreach (var err in res["errors"])
                                {
                                    errors.append(err);
                                }
                            }
                            funcArr.append(res["result"]);
                        }
                        //invoke function
                        var jaes = f(root, funcArr);
                        success = success && jaes["success"];
                        if (!jaes["success"])
                        {
                            foreach (var err in jaes["errors"])
                            {
                                errors.append(err);
                            }
                        }
                        //if successful try to recurse into result for functions in result
                        if (jaes["success"])
                        {
                            res = find_and_replace_references(root, jaes["result"]);
                            success = success && res["success"];
                            if (!res["success"])
                            {
                                foreach (var err in res["errors"])
                                {
                                    errors.append(err);
                                }
                            }
                            return new Dictionary<object, object> {
                            {
                                "result",
                                res["result"]},
                            {
                                "errors",
                                errors},
                            {
                                "success",
                                errors.Count == 0}};
                        }
                        else
                        {
                            return new Dictionary<object, object> {
                            {
                                "result",
                                new Dictionary<object, object> {
                                }},
                            {
                                "errors",
                                errors},
                            {
                                "success",
                                errors.Count == 0}};
                        }
                    }
                }
                if (!array_is_reference_function)
                {
                    foreach (var jv in j)
                    {
                        res = find_and_replace_references(root, jv);
                        success = success && res["success"];
                        if (!res["success"])
                        {
                            foreach (var err in res["errors"])
                            {
                                errors.append(err);
                            }
                        }
                        arr.append(res["result"]);
                    }
                }
                return new Dictionary<object, object> {
                {
                    "result",
                    arr},
                {
                    "errors",
                    errors},
                {
                    "success",
                    errors.Count == 0}};
            }
            else if (j is dict)
            {
                var obj = new Dictionary<object, object>
                {
                };
                foreach (var _tup_1 in j.items())
                {
                    var k = _tup_1.Item1;
                    var v = _tup_1.Item2;
                    var r = find_and_replace_references(root, v);
                    success = success && r["success"];
                    if (!r["success"])
                    {
                        foreach (var e in r["errors"])
                        {
                            errors.append(e);
                        }
                    }
                    obj[k] = r["result"];
                }
                return new Dictionary<object, object> {
                {
                    "result",
                    obj},
                {
                    "errors",
                    errors},
                {
                    "success",
                    errors.Count == 0}};
            }
            return new Dictionary<object, object> {
            {
                "result",
                j},
            {
                "errors",
                errors},
            {
                "success",
                errors.Count == 0}};
        }

        // 
        //     auto fromDb = [](const Json&, const Json& j) -> EResult<Json>
        //     {
        //         if((j.array_items().size() >= 3 && j[1].is_string())
        //            || (j.array_items().size() == 2 && j[1].is_object()))
        //         {
        //             bool isParamMap = j[1].is_object();
        // 
        //             auto type = isParamMap ? j[1]["type"].string_value() :j[1].string_value();
        //             string err;
        //             string db = isParamMap && j[1].has_shape({{"db", Json::STRING}}, err)
        //                         ? j[1]["db"].string_value()
        //                         : "";
        //             if(type == "mineral_fertiliser")
        //             {
        //                 if(db.empty())
        //                     db = "monica";
        //                 auto name = isParamMap ? j[1]["name"].string_value() : j[2].string_value();
        //                 return{getMineralFertiliserParametersFromMonicaDB(name, db).to_json()};
        //             }
        //             else if(type == "organic_fertiliser")
        //             {
        //                 if(db.empty())
        //                     db = "monica";
        //                 auto name = isParamMap ? j[1]["name"].string_value() : j[2].string_value();
        //                 return{getOrganicFertiliserParametersFromMonicaDB(name, db)->to_json()};
        //             }
        //             else if(type == "crop_residue"
        //                     && j.array_items().size() >= 3)
        //             {
        //                 if(db.empty())
        //                     db = "monica";
        //                 auto species = isParamMap ? j[1]["species"].string_value() : j[2].string_value();
        //                 auto residueType = isParamMap ? j[1]["residue-type"].string_value()
        //                                               : j.array_items().size() == 4 ? j[3].string_value()
        //                                                                             : "";
        //                 return{getResidueParametersFromMonicaDB(species, residueType, db)->to_json()};
        //             }
        //             else if(type == "species")
        //             {
        //                 if(db.empty())
        //                     db = "monica";
        //                 auto species = isParamMap ? j[1]["species"].string_value() : j[2].string_value();
        //                 return{getSpeciesParametersFromMonicaDB(species, db)->to_json()};
        //             }
        //             else if(type == "cultivar"
        //                     && j.array_items().size() >= 3)
        //             {
        //                 if(db.empty())
        //                     db = "monica";
        //                 auto species = isParamMap ? j[1]["species"].string_value() : j[2].string_value();
        //                 auto cultivar = isParamMap ? j[1]["cultivar"].string_value()
        //                                            : j.array_items().size() == 4 ? j[3].string_value()
        //                                                                          : "";
        //                 return{getCultivarParametersFromMonicaDB(species, cultivar, db)->to_json()};
        //             }
        //             else if(type == "crop"
        //                     && j.array_items().size() >= 3)
        //             {
        //                 if(db.empty())
        //                     db = "monica";
        //                 auto species = isParamMap ? j[1]["species"].string_value() : j[2].string_value();
        //                 auto cultivar = isParamMap ? j[1]["cultivar"].string_value()
        //                                            : j.array_items().size() == 4 ? j[3].string_value()
        //                                                                          : "";
        //                 return{getCropParametersFromMonicaDB(species, cultivar, db)->to_json()};
        //             }
        //             else if(type == "soil-temperature-params")
        //             {
        //                 if(db.empty())
        //                     db = "monica";
        //                 auto module = isParamMap ? j[1]["name"].string_value() : j[2].string_value();
        //                 return{readUserSoilTemperatureParametersFromDatabase(module, db).to_json()};
        //             }
        //             else if(type == "environment-params")
        //             {
        //                 if(db.empty())
        //                     db = "monica";
        //                 auto module = isParamMap ? j[1]["name"].string_value() : j[2].string_value();
        //                 return{readUserEnvironmentParametersFromDatabase(module, db).to_json()};
        //             }
        //             else if(type == "soil-organic-params")
        //             {
        //                 if(db.empty())
        //                     db = "monica";
        //                 auto module = isParamMap ? j[1]["name"].string_value() : j[2].string_value();
        //                 return{readUserSoilOrganicParametersFromDatabase(module, db).to_json()};
        //             }
        //             else if(type == "soil-transport-params")
        //             {
        //                 if(db.empty())
        //                     db = "monica";
        //                 auto module = isParamMap ? j[1]["name"].string_value() : j[2].string_value();
        //                 return{readUserSoilTransportParametersFromDatabase(module, db).to_json()};
        //             }
        //             else if(type == "soil-moisture-params")
        //             {
        //                 if(db.empty())
        //                     db = "monica";
        //                 auto module = isParamMap ? j[1]["name"].string_value() : j[2].string_value();
        //                 return{readUserSoilTemperatureParametersFromDatabase(module, db).to_json()};
        //             }
        //             else if(type == "crop-params")
        //             {
        //                 if(db.empty())
        //                     db = "monica";
        //                 auto module = isParamMap ? j[1]["name"].string_value() : j[2].string_value();
        //                 return{readUserCropParametersFromDatabase(module, db).to_json()};
        //             }
        //             else if(type == "soil-profile"
        //                     && (isParamMap
        //                         || (!isParamMap && j[2].is_number())))
        //             {
        //                 if(db.empty())
        //                     db = "soil";
        //                 vector<Json> spjs;
        //                 int profileId = isParamMap ? j[1]["id"].int_value() : j[2].int_value();
        //                 auto sps = Soil::soilParameters(db, profileId);
        //                 for(auto sp : *sps)
        //                     spjs.push_back(sp.to_json());
        // 
        //                 return{spjs};
        //             }
        //             else if(type == "soil-layer"
        //                     && (isParamMap
        //                         || (j.array_items().size() == 4
        //                             && j[2].is_number()
        //                             && j[3].is_number())))
        //             {
        //                 if(db.empty())
        //                     db = "soil";
        //                 int profileId = isParamMap ? j[1]["id"].int_value() : j[2].int_value();
        //                 size_t layerNo = size_t(isParamMap ? j[1]["no"].int_value() : j[3].int_value());
        //                 auto sps = Soil::soilParameters(db, profileId);
        //                 if(0 < layerNo && layerNo <= sps->size())
        //                     return{sps->at(layerNo - 1).to_json()};
        // 
        //                 return{j, string("Couldn't load soil-layer from database: ") + j.dump() + "!"};
        //             }
        //         }
        // 
        //         return{j, string("Couldn't load data from DB: ") + j.dump() + "!"};
        //     };
        //     
        public static object supported_patterns()
        {
            Func<object, object, object> @ref = (root, j) => {
                if (!@ref.@__dict__.Contains("cache"))
                {
                    @ref.cache = new Dictionary<object, object>
                    {
                    };
                }
                if (j.Count == 3 && is_string_type(j[1]) && is_string_type(j[2]))
                {
                    var key1 = j[1];
                    var key2 = j[2];
                    if (@ref.cache.Contains(Tuple.Create(key1, key2)))
                    {
                        return @ref.cache[Tuple.Create(key1, key2)];
                    }
                    var res = find_and_replace_references(root, root[key1][key2]);
                    @ref.cache[Tuple.Create(key1, key2)] = res;
                    return res;
                }
                return new Dictionary<object, object> {
                {
                    "result",
                    j},
                {
                    "errors",
                    new List<object> {
                        "Couldn't resolve reference: " + json.dumps(j) + "!"
                    }},
                {
                    "success",
                    false}};
            };
            Func<object, object, object> from_file = (root, @j__) => {
                if (@j__.Count == 2 && is_string_type(@j__[1]))
                {
                    var base_path = default_value(root, "include-file-base-path", ".");
                    var path_to_file = @j__[1];
                    if (!is_absolute_path(path_to_file))
                    {
                        path_to_file = base_path + "/" + path_to_file;
                    }
                    path_to_file = replace_env_vars(path_to_file);
                    path_to_file = fix_system_separator(path_to_file);
                    var jo_ = read_and_parse_json_file(path_to_file);
                    if (jo_["success"] && !(jo_["result"] is type(None)))
                    {
                        return new Dictionary<object, object> {
                        {
                            "result",
                            jo_["result"]},
                        {
                            "errors",
                            new List<object>()},
                        {
                            "success",
                            true}};
                    }
                    return new Dictionary<object, object> {
                    {
                        "result",
                        @j__},
                    {
                        "errors",
                        new List<object> {
                            "Couldn't include file with path: '" + path_to_file + "'!"
                        }},
                    {
                        "success",
                        false}};
                }
                return new Dictionary<object, object> {
                {
                    "result",
                    @j__},
                {
                    "errors",
                    new List<object> {
                        "Couldn't include file with function: " + json.dumps(@j__) + "!"
                    }},
                {
                    "success",
                    false}};
            };
            Func<object, object, object> humus_to_corg = (_, @j__) => {
                if (@j__.Count == 2 && @j__[1] is int)
                {
                    return new Dictionary<object, object> {
                    {
                        "result",
                        soil_io3.humus_class_to_corg(@j__[1])},
                    {
                        "errors",
                        new List<object>()},
                    {
                        "success",
                        true}};
                }
                return new Dictionary<object, object> {
                {
                    "result",
                    @j__},
                {
                    "errors",
                    new List<object> {
                        "Couldn't convert humus level to corg: " + json.dumps(@j__) + "!"
                    }},
                {
                    "success",
                    false}};
            };
            Func<object, object, object> ld_to_trd = (_, @j__) => {
                if (@j__.Count == 3 && @j__[1] is int && @j__[2] is float)
                {
                    return new Dictionary<object, object> {
                    {
                        "result",
                        soil_io3.bulk_density_class_to_raw_density(@j__[1], @j__[2])},
                    {
                        "errors",
                        new List<object>()},
                    {
                        "success",
                        true}};
                }
                return new Dictionary<object, object> {
                {
                    "result",
                    @j__},
                {
                    "errors",
                    new List<object> {
                        "Couldn't convert bulk density class to raw density using function: " + json.dumps(@j__) + "!"
                    }},
                {
                    "success",
                    false}};
            };
            Func<object, object, object> ka5_to_clay = (_, @j__) => {
                if (@j__.Count == 2 && is_string_type(@j__[1]))
                {
                    return new Dictionary<object, object> {
                    {
                        "result",
                        soil_io3.ka5_texture_to_clay(@j__[1])},
                    {
                        "errors",
                        new List<object>()},
                    {
                        "success",
                        true}};
                }
                return new Dictionary<object, object> {
                {
                    "result",
                    @j__},
                {
                    "errors",
                    new List<object> {
                        "Couldn't get soil clay content from KA5 soil class: " + json.dumps(@j__) + "!"
                    }},
                {
                    "success",
                    false}};
            };
            Func<object, object, object> ka5_to_sand = (_, @j__) => {
                if (@j__.Count == 2 && is_string_type(@j__[1]))
                {
                    return new Dictionary<object, object> {
                    {
                        "result",
                        soil_io3.ka5_texture_to_sand(@j__[1])},
                    {
                        "errors",
                        new List<object>()},
                    {
                        "success",
                        true}};
                }
                return new Dictionary<object, object> {
                {
                    "result",
                    @j__},
                {
                    "errors",
                    new List<object> {
                        "Couldn't get soil sand content from KA5 soil class: " + json.dumps(@j__) + "!"
                    }},
                {
                    "success",
                    false}};
            };
            Func<object, object, object> sand_clay_to_lambda = (_, @j__) => {
                if (@j__.Count == 3 && @j__[1] is float && @j__[2] is float)
                {
                    return new Dictionary<object, object> {
                    {
                        "result",
                        soil_io3.sand_and_clay_to_lambda(@j__[1], @j__[2])},
                    {
                        "errors",
                        new List<object>()},
                    {
                        "success",
                        true}};
                }
                return new Dictionary<object, object> {
                {
                    "result",
                    @j__},
                {
                    "errors",
                    new List<object> {
                        "Couldn't get lambda value from soil sand and clay content: " + json.dumps(@j__) + "!"
                    }},
                {
                    "success",
                    false}};
            };
            Func<object, object, object> percent = (_, @j__) => {
                if (@j__.Count == 2 && @j__[1] is float)
                {
                    return new Dictionary<object, object> {
                    {
                        "result",
                        @j__[1] / 100.0},
                    {
                        "errors",
                        new List<object>()},
                    {
                        "success",
                        true}};
                }
                return new Dictionary<object, object> {
                {
                    "result",
                    @j__},
                {
                    "errors",
                    new List<object> {
                        "Couldn't convert percent to decimal percent value: " + json.dumps(@j__) + "!"
                    }},
                {
                    "success",
                    false}};
            };
            if (!supported_patterns.@__dict__.Contains("m"))
            {
                supported_patterns.m = new Dictionary<object, object> {
                {
                    "include-from-file",
                    from_file},
                {
                    "ref",
                    @ref},
                {
                    "humus_st2corg",
                    humus_to_corg},
                {
                    "humus-class->corg",
                    humus_to_corg},
                {
                    "ld_eff2trd",
                    ld_to_trd},
                {
                    "bulk-density-class->raw-density",
                    ld_to_trd},
                {
                    "KA5TextureClass2clay",
                    ka5_to_clay},
                {
                    "KA5-texture-class->clay",
                    ka5_to_clay},
                {
                    "KA5TextureClass2sand",
                    ka5_to_sand},
                {
                    "KA5-texture-class->sand",
                    ka5_to_sand},
                {
                    "sandAndClay2lambda",
                    sand_clay_to_lambda},
                {
                    "sand-and-clay->lambda",
                    sand_clay_to_lambda},
                {
                    "%",
                    percent}};
            }
            return supported_patterns.m;
        }

        public static object print_possible_errors(object errs, object include_warnings = false)
        {
            if (!errs["success"])
            {
                foreach (var err in errs["errors"])
                {
                    Console.WriteLine(err);
                }
            }
            if (include_warnings && errs.Contains("warnings"))
            {
                foreach (var war in errs["warnings"])
                {
                    Console.WriteLine(war);
                }
            }
            return errs["success"];
        }

        // create the json version of the env from the json config files
        public static object create_env_json_from_json_config(object crop_site_sim)
        {
            object j;
            object k;
            foreach (var _tup_1 in crop_site_sim.items())
            {
                k = _tup_1.Item1;
                j = _tup_1.Item2;
                if (j == null)
                {
                    return null;
                }
            }
            var path_to_parameters = crop_site_sim["sim"]["include-file-base-path"];
            Func<object, object, object> add_base_path = (j, base_path) => {
                if (!j.Contains("include-file-base-path"))
                {
                    j["include-file-base-path"] = base_path;
                }
            };
            var crop_site_sim2 = new Dictionary<object, object>
            {
            };
            //collect all errors in all files and don't stop as early as possible
            var errors = new HashSet<object>();
            foreach (var _tup_2 in crop_site_sim.items())
            {
                k = _tup_2.Item1;
                j = _tup_2.Item2;
                if (k == "climate")
                {
                    continue;
                }
                add_base_path(j, path_to_parameters);
                var res = find_and_replace_references(j, j);
                if (res["success"])
                {
                    crop_site_sim2[k] = res["result"];
                }
                else
                {
                    errors.update(res["errors"]);
                }
            }
            if (errors.Count > 0)
            {
                foreach (var err in errors)
                {
                    Console.WriteLine(err);
                }
                return null;
            }
            var cropj = crop_site_sim2["crop"];
            var sitej = crop_site_sim2["site"];
            var simj = crop_site_sim2["sim"];
            var env = new Dictionary<object, object>
            {
            };
            env["type"] = "Env";
            //store debug mode in env, take from sim.json, but prefer params map
            env["debugMode"] = simj["debug?"];
            var cpp = new Dictionary<object, object> {
            {
                "type",
                "CentralParameterProvider"},
            {
                "userCropParameters",
                cropj["CropParameters"]},
            {
                "userEnvironmentParameters",
                sitej["EnvironmentParameters"]},
            {
                "userSoilMoistureParameters",
                sitej["SoilMoistureParameters"]},
            {
                "userSoilTemperatureParameters",
                sitej["SoilTemperatureParameters"]},
            {
                "userSoilTransportParameters",
                sitej["SoilTransportParameters"]},
            {
                "userSoilOrganicParameters",
                sitej["SoilOrganicParameters"]},
            {
                "simulationParameters",
                simj},
            {
                "siteParameters",
                sitej["SiteParameters"]}};
            env["params"] = cpp;
            env["cropRotation"] = cropj.get("cropRotation", null);
            env["cropRotations"] = cropj.get("cropRotations", null);
            env["events"] = simj["output"]["events"];
            env["pathToClimateCSV"] = simj["climate.csv"];
            env["csvViaHeaderOptions"] = simj["climate.csv-options"];
            env["csvViaHeaderOptions"]["latitude"] = sitej["SiteParameters"]["Latitude"];
            var climate_csv_string = crop_site_sim.Contains("climate") ? crop_site_sim["climate"] : "";
            if (climate_csv_string)
            {
                add_climate_data_to_env(env, simj, climate_csv_string);
            }
            return env;
        }

        // add climate data separately to env
        public static object add_climate_data_to_env(object env, object simj, object climate_csv_string = "")
        {
            //if not climate_csv_string:
            //    with open(simj["climate.csv"]) as _:
            //        climate_csv_string = _.read()
            //if climate_csv_string:
            //    env["climateData"] = json.loads(monica_python.readClimateDataFromCSVStringViaHeadersToJsonString(climate_csv_string, json.dumps(simj["climate.csv-options"])))
            return env;
        }
    }
    */


}


}
