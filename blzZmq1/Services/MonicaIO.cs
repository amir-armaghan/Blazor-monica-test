﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Web.Script.Serialization;


namespace blzZmq1.Services
{
    public class MonicaIO
    {
        private static int OP_AVG = 0;
        private static int OP_MEDIAN = 1;
        private static int OP_SUM = 2;
        private static int OP_MIN = 3;
        private static int OP_MAX = 4;
        private static int OP_FIRST = 5;
        private static int OP_LAST = 6;
        private static int OP_NONE = 7;
        private static int OP_UNDEFINED_OP_ = 8;
        private static int ORGAN_ROOT = 0;
        private static int ORGAN_LEAF = 1;
        private static int ORGAN_SHOOT = 2;
        private static int ORGAN_FRUIT = 3;
        private static int ORGAN_STRUCT = 4;
        private static int ORGAN_SUGAR = 5;
        private static int ORGAN_UNDEFINED_ORGAN_ = 6;

        private static bool oid_is_organ(dynamic oid)
        {
            return Convert.ToInt32(oid["organ"]) != ORGAN_UNDEFINED_ORGAN_;
        }
        private static bool oid_is_range(dynamic oid)
        {
            return (Convert.ToInt32(oid["fromLayer"]) >= 0 && Convert.ToInt32(oid["toLayer"]) >= 0);
        }
        private static string op_to_string(int op)
        {
            var dic = new Dictionary<int, string>();
            dic.Add(OP_AVG, "AVG");
            dic.Add(OP_MEDIAN, "MEDIAN");
            dic.Add(OP_SUM, "SUM");
            dic.Add(OP_MIN, "MIN");
            dic.Add(OP_MAX, "MAX");
            dic.Add(OP_FIRST, "FIRST");
            dic.Add(OP_LAST, "LAST");
            dic.Add(OP_NONE, "NONE");
            dic.Add(OP_UNDEFINED_OP_, "undef");

            if (dic.ContainsKey(op))
                return dic[op];
            else
                return "undef";
        }
        private static string organ_to_string(int organ)
        {
            var dic = new Dictionary<int, string>();
            dic.Add(ORGAN_ROOT, "Root");
            dic.Add(ORGAN_LEAF, "Leaf");
            dic.Add(ORGAN_SHOOT, "Shoot");
            dic.Add(ORGAN_FRUIT, "Fruit");
            dic.Add(ORGAN_STRUCT, "Struct");
            dic.Add(ORGAN_SUGAR, "Sugar");
            dic.Add(ORGAN_UNDEFINED_ORGAN_, "undef");

            /*var dic = new Dictionary<int, string>
            {
                { ORGAN_ROOT, "Root" },
                { ORGAN_LEAF, "Leaf" },
                { ORGAN_SHOOT, "Shoot" },
                { ORGAN_FRUIT, "Fruit" },
                { ORGAN_STRUCT, "Struct" },
                { ORGAN_SUGAR, "Sugar" },
                { ORGAN_UNDEFINED_ORGAN_, "undef" },
            };*/

            if (dic.ContainsKey(organ))
                return dic[organ];
            else
                return "undef";
        }
        private static string oid_to_string(dynamic oid, bool include_time_agg)
        {
            StringBuilder oss = new StringBuilder();
            oss.Append("[");
            oss.Append(oid["name"]);
            if (oid_is_organ(oid))
            {
                oss.Append(", " + organ_to_string(Convert.ToInt32(oid["organ"])));
            }
            else if (oid_is_range(oid))
            {
                oss.Append(", [");
                oss.Append((Convert.ToInt32(oid["fromLayer"]) + 1).ToString());
                oss.Append(", ");
                oss.Append((Convert.ToInt32(oid["toLayer"]) + 1).ToString());
                oss.Append(Convert.ToInt32(oid["layerAggOp"]) != OP_NONE ? ", " + op_to_string(Convert.ToInt32(oid["layerAggOp"])) : "");
                oss.Append("]");
            }
            else if (Convert.ToInt32(oid["fromLayer"]) >= 0)
            {
                oss.Append(", " + (Convert.ToInt32(oid["fromLayer"]) + 1).ToString());
            }
            if (include_time_agg)
            {
                oss.Append(", " + op_to_string(Convert.ToInt32(oid["timeAggOp"])));
            }
            oss.Append("]");

            return oss.ToString();
        }
        // write header rows
        private static List<string> write_output_header_rows(JObject output_ids,
            bool include_header_row = true,
            bool include_units_row = true,
            bool include_time_agg = false)
        {
            var row1 = new List<string>();
            var row2 = new List<string>();
            var row3 = new List<string>();
            var row4 = new List<string>();
            foreach (var __item in output_ids)
            {
                string key = __item.Key;
                JObject oid = __item.Value as JObject;
                var from_layer = Convert.ToInt32(oid["fromLayer"]);
                var to_layer = Convert.ToInt32(oid["toLayer"]);
                var is_organ = oid_is_organ(oid);
                var is_range = oid_is_range(oid) && Convert.ToInt32(oid["layerAggOp"]) == OP_NONE;
                if (is_organ)
                {
                    // organ is being represented just by the value of fromLayer currently
                    to_layer = Convert.ToInt32(oid["organ"]);
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
                foreach (var i in Enumerable.Range(from_layer, to_layer + 1 - from_layer))
                {
                    var str1 = "";
                    if (is_organ)
                    {
                        str1 += oid["displayName"].Count() == 0 ? oid["name"] + "/" + organ_to_string(Convert.ToInt32(oid["organ"])) : oid["displayName"];
                    }
                    else if (is_range)
                    {
                        str1 += oid["displayName"].Count() == 0 ? oid["name"] + "_" + i.ToString() : oid["displayName"];
                    }
                    else
                    {
                        str1 += oid["displayName"].Count() == 0 ? oid["name"] : oid["displayName"];
                    }
                    row1.Add(str1);
                    row4.Add("j:" + oid["jsonInput"].ToString().Replace("\"", ""));
                    row3.Add("m:" + oid_to_string(oid, include_time_agg));
                    row2.Add("[" + oid["unit"] + "]");
                }
            }
            var res = new List<string>();
            if (include_header_row)
            {
                res.AddRange(row1);
            }
            if (include_units_row)
            {
                res.AddRange(row4);
            }
            if (include_time_agg)
            {
                res.AddRange(row3);
                res.AddRange(row2);
            }
            return res;
        }
        // write actual output lines
        private static object write_output(JObject output_ids, JArray values)
        {
            var @out = new List<object>();
            if (values.Count > 0)
            {
                foreach (var k in Enumerable.Range(0, values[0].Count()))
                {
                    var i = 0;
                    var row = new List<object>();
                    foreach (var _ in output_ids)
                    {
                        var @j__ = values[i][k];
                        if (@j__ is JArray)
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
        private static bool is_absolute_path(string p)
        {
            return p.StartsWith("/") || p.Length == 2 && p[1] == ':' || p.Length > 2 && p[1] == ':' && (p[2] == '\\' || p[2] == '/');
        }
        private static string fix_system_separator(string path)
        {
            path = path.Replace("\\", "/");
            var new_path = path;
            while (true)
            {
                new_path = path.Replace("//", "/");
                if (new_path == path)
                {
                    break;
                }
                path = new_path;
            }
            return new_path;
        }
        private static string replace_env_vars(string path)
        {
            var start_token = "${";
            var end_token = "}";
            var start_pos = path.IndexOf(start_token);
            while (start_pos > -1)
            {
                var end_pos = path.IndexOf(end_token, start_pos + 1);
                if (end_pos > -1)
                {
                    var name_start = start_pos + 2;
                    var env_var_name = path.Substring(name_start, end_pos - start_pos);
                    var env_var_content = Environment.GetEnvironmentVariable(env_var_name);
                    if (env_var_content != null)
                    {
                        path = path.Replace(path.Substring(start_pos, (end_pos + 1) - start_pos), env_var_content);
                        start_pos = path.IndexOf(start_token);
                    }
                    else
                    {
                        start_pos = path.IndexOf(start_token, end_pos + 1);
                    }
                }
                else
                {
                    break;
                }
            }
            return path;
        }
        private static string default_value(JObject dic, string key, string @default)
        {
            return dic.ContainsKey(key) ? dic[key].ToString() : @default;
        }
        private static JObject read_and_parse_json_file(string path)
        {
            var res = new JObject();
            try
            {
                var ssjsn = JObject.Parse(File.ReadAllText(path));
                res.Add("result", ssjsn);
                res.Add("errors", new JArray());
                res.Add("success", true);
            }
            catch
            {
                res.Add("result", new JObject());
                res.Add("errors", "Error opening file with path: '" + path + "'!");
                res.Add("success", false);
            }
            return res;
        }
        private static object parse_json_string(string jsonString)
        {
            var res = new JObject();
            res.Add("result", JObject.Parse(jsonString));
            res.Add("errors", new JArray());
            res.Add("success", true);
            return res;
        }
        private static bool is_string_type(JValue j)
        {
            if (j == null)
                return false;
            return j.Type == JTokenType.String;
        }
        private static JObject find_and_replace_references(JToken root, JToken j)
        {
            JObject res;
            var success = true;
            var errors = new List<string>();
            if (j is JArray && (j as JArray).Count > 0)
            {
                var arr = new List<object>();
                var array_is_reference_function = false;
                if (is_string_type(j[0] as JValue))
                {
                    if (SupportedPatterns.Contains(j[0].ToString()))
                    {
                        string function = j[0].ToString();
                        array_is_reference_function = true;

                        //check for nested function invocations in the arguments
                        var funcArr = new JArray();
                        foreach (var i in j)
                        {
                            res = find_and_replace_references(root, i);
                            success = success && Convert.ToBoolean(res["success"]);
                            if (!Convert.ToBoolean(res["success"]))
                            {
                                foreach (var err in res["errors"])
                                {
                                    errors.Add(err.ToString());
                                }
                            }
                            funcArr.Add(res["result"]);
                        }
                        //invoke function
                        var jaes = SupportedPatterns.GetValue(function, root, funcArr);
                        success = success && Convert.ToBoolean(jaes["success"]);
                        if (!Convert.ToBoolean(jaes["success"]))
                        {
                            foreach (var err in jaes["errors"])
                            {
                                errors.Add(err.ToString());
                            }
                        }
                        //if successful try to recurse into result for functions in result
                        if (Convert.ToBoolean(jaes["success"]))
                        {
                            res = find_and_replace_references(root, jaes["result"]);
                            success = success && Convert.ToBoolean(res["success"]);
                            if (!Convert.ToBoolean(res["success"]))
                            {
                                foreach (var err in res["errors"])
                                {
                                    errors.Add(err.ToString());
                                }
                            }
                            var ccc1 = new JObject();
                            ccc1.Add("result", res["result"]);
                            ccc1.Add("errors", new JArray(errors.ToArray()));
                            ccc1.Add("success", errors.Count == 0);
                            return ccc1;
                        }
                        else
                        {
                            var ccc1 = new JObject();
                            ccc1.Add("result", new JArray());
                            ccc1.Add("errors", new JArray(errors.ToArray()));
                            ccc1.Add("success", errors.Count == 0);
                            return ccc1;
                        }
                    }
                }
                if (!array_is_reference_function)
                {
                    foreach (var jv in j)
                    {
                        res = find_and_replace_references(root, jv);
                        success = success && Convert.ToBoolean(res["success"]);
                        if (!Convert.ToBoolean(res["success"]))
                        {
                            foreach (var err in res["errors"])
                            {
                                errors.Add(err.ToString());
                            }
                        }
                        arr.Add(res["result"]);
                    }
                }
                var ccc2 = new JObject();
                ccc2.Add("result", new JArray(arr.ToArray()));
                ccc2.Add("errors", new JArray(errors.ToArray()));
                ccc2.Add("success", errors.Count == 0);
                return ccc2;
            }
            else if (j is JObject)
            {
                var obj = new JObject();
                foreach (var item in (j as JObject))
                {
                    var k = item.Key;
                    var v = item.Value;
                    var r = find_and_replace_references(root, v);
                    success = success && Convert.ToBoolean(r["success"]);
                    if (!Convert.ToBoolean(r["success"]))
                    {
                        foreach (var e in r["errors"])
                        {
                            errors.Add(e.ToString());
                        }
                    }
                    obj.Add(k, r["result"]);
                }
                var ccc2 = new JObject();
                ccc2.Add("result", obj);
                ccc2.Add("errors", new JArray(errors.ToArray()));
                ccc2.Add("success", errors.Count == 0);
                return ccc2;
            }
            var ccc3 = new JObject();
            ccc3.Add("result", j);
            ccc3.Add("errors", new JArray(errors.ToArray()));
            ccc3.Add("success", errors.Count == 0);
            return ccc3;
        }
        private static bool print_possible_errors(JObject errs, bool include_warnings = false)
        {
            if (!(bool)errs["success"])
            {
                foreach (var err in errs["errors"])
                {
                    Console.WriteLine(err);
                }
            }
            if (include_warnings && errs.ContainsKey("warnings"))
            {
                foreach (var war in errs["warnings"])
                {
                    Console.WriteLine(war);
                }
            }
            return (bool)errs["success"];
        }
        public static JObject create_env_json_from_json_config(JObject crop_site_sim)
        {
            JToken jTkn;
            string key;
            foreach (var item in crop_site_sim)
            {
                key = item.Key;
                jTkn = item.Value;
                if (jTkn == null)
                {
                    return null;
                }
            }

            var path_to_parameters = crop_site_sim["sim"]["include-file-base-path"];

            var crop_site_sim2 = new JObject();

            //collect all errors in all files and don't stop as early as possible
            var errors = new List<string>();
            foreach (var item in crop_site_sim)
            {
                key = item.Key;
                jTkn = item.Value;
                if (key == "climate")
                {
                    continue;
                }
                add_base_path(jTkn as JObject, path_to_parameters);
                var res = find_and_replace_references(jTkn, jTkn);
                if (Convert.ToBoolean(res["success"]))
                {
                    crop_site_sim2.Add(key, res["result"]);
                }
                else
                {
                    var ers = res["errors"] as JArray;
                    for (int ii = 0; ii < ers.Count; ii++)
                    {
                        errors.Add(ers[ii].ToString());
                    }
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
            var env = new JObject();
            env.Add("type", "Env");
            //store debug mode in env, take from sim.json, but prefer params map
            env.Add("debugMode", simj["debug?"]);
            var cpp = new JObject()
            {{
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
                sitej["SiteParameters"]}
            };
            env.Add("params", cpp);
            env.Add("cropRotation", cropj["cropRotation"]);
            env.Add("cropRotations", cropj["cropRotations"]);
            env.Add("events", simj["output"]["events"]);
            env.Add("pathToClimateCSV", simj["climate.csv"]);
            env.Add("csvViaHeaderOptions", simj["climate.csv-options"]);
            env["csvViaHeaderOptions"]["latitude"] = sitej["SiteParameters"]["Latitude"];
            var climate_csv_string = crop_site_sim.ContainsKey("climete") ? crop_site_sim["climate"] : "";
            if (!string.IsNullOrEmpty(climate_csv_string.ToString()))
            {
                add_climate_data_to_env(env, simj, climate_csv_string.ToString());
            }
            return env;
        }
        private static JObject add_climate_data_to_env(JObject env, JToken simj, string climate_csv_string = "")
        {
            //if not climate_csv_string:
            //    with open(simj["climate.csv"]) as _:
            //        climate_csv_string = _.read()
            //if climate_csv_string:
            //    env["climateData"] = json.loads(monica_python.readClimateDataFromCSVStringViaHeadersToJsonString(climate_csv_string, json.dumps(simj["climate.csv-options"])))
            return env;
        }

        private static void add_base_path(JObject j, JToken base_path)
        {
            if (!j.ContainsKey("include-file-base-path"))
            {
                j.Add("include-file-base-path", base_path);
            }
        }

        class SupportedPatterns
        {
            public static JObject @ref(JObject root, JArray j)
            {
                if (j != null && j.Count == 3 && is_string_type(j[1] as JValue) && is_string_type(j[2] as JValue))
                {
                    var key1 = j[1].ToString();
                    var key2 = j[2].ToString();
                    return find_and_replace_references(root, root[key1][key2]);

                }
                var res = new JObject();
                res.Add("result", j);
                res.Add("errors", new JArray("Couldn't resolve reference: " + j.ToString() + "!"));
                res.Add("success", false);
                return res;
            }
            public static JObject from_file(JObject root, JArray j)
            {
                if (j != null && j.Count == 2 && is_string_type(j[1] as JValue))
                {
                    var base_path = default_value(root, "include-file-base-path", ".");
                    var path_to_file = j[1].ToString();
                    if (!is_absolute_path(path_to_file))
                    {
                        path_to_file = base_path + "/" + path_to_file;
                    }
                    path_to_file = replace_env_vars(path_to_file);
                    path_to_file = fix_system_separator(path_to_file);
                    var jo_ = read_and_parse_json_file(path_to_file);
                    if (Convert.ToBoolean(jo_["success"]) && jo_["result"] != null)
                    {
                        var res = new JObject();
                        res.Add("result", jo_["result"] as JToken);
                        res.Add("errors", new JArray());
                        res.Add("success", true);
                        return res;
                    }
                    var res2 = new JObject();
                    res2.Add("result", j);
                    res2.Add("errors", new JArray("Couldn't include file with path: '" + path_to_file + "'!"));
                    res2.Add("success", false);
                    return res2;
                }
                var res3 = new JObject();
                res3.Add("result", j);
                res3.Add("errors", new JArray("Couldn't include file with function: " + j.ToString() + "!"));
                res3.Add("success", false);
                return res3;
            }
            public static JObject ld_to_trd(JObject root, JArray j)
            {
                if (j != null && j.Count == 3 && is_int(j[1] as JValue) && is_float(j[2] as JValue))
                {
                    var res = new JObject();
                    res.Add("result", SoilIO.bulk_density_class_to_raw_density((int)j[1], (double)j[2]));
                    res.Add("errors", new JArray());
                    res.Add("success", true);
                    return res;
                }
                var res2 = new JObject();
                res2.Add("result", j);
                res2.Add("errors", new JArray("Couldn't convert bulk density class to raw density using function: " + j.ToString() + "!"));
                res2.Add("success", false);
                return res2;
            }
            public static JObject ka5_to_clay(object root, JArray j)
            {
                if (j != null && j.Count == 2 && is_string_type(j[1] as JValue))
                {
                    var res = new JObject();
                    res.Add("result", SoilIO.ka5_texture_to_clay(j[1].ToString()));
                    res.Add("errors", new JArray());
                    res.Add("success", true);
                    return res;
                }
                var res2 = new JObject();
                res2.Add("result", j);
                res2.Add("errors", new JArray("Couldn't get soil clay content from KA5 soil class: " + j.ToString() + "!"));
                res2.Add("success", false);
                return res2;
            }
            public static JObject ka5_to_sand(object root, JArray j)
            {
                if (j != null && j.Count == 2 && is_string_type(j[1] as JValue))
                {
                    var res = new JObject();
                    res.Add("result", SoilIO.ka5_texture_to_sand(j[1].ToString()));
                    res.Add("errors", new JArray());
                    res.Add("success", true);
                    return res;
                }
                var res2 = new JObject();
                res2.Add("result", j);
                res2.Add("errors", new JArray("Couldn't get soil sand content from KA5 soil class: " + j.ToString() + "!"));
                res2.Add("success", false);
                return res2;
            }
            public static JObject sand_clay_to_lambda(object root, JArray j)
            {
                if (j != null && j.Count == 2 && is_float(j[1] as JValue) && is_float(j[2] as JValue))
                {
                    var res = new JObject();
                    res.Add("result", SoilIO.sand_and_clay_to_lambda((double)j[1], (double)j[2]));
                    res.Add("errors", new JArray());
                    res.Add("success", true);
                    return res;
                }
                var res2 = new JObject();
                res2.Add("result", j);
                res2.Add("errors", new JArray("Couldn't get lambda value from soil sand and clay content: " + j.ToString() + "!"));
                res2.Add("success", false);
                return res2;
            }
            public static JObject percent(object root, JArray j)
            {
                if (j != null && j.Count == 2 && is_float(j[1] as JValue))
                {
                    var res = new JObject();
                    res.Add("result", (float)j[1] / 100.0);
                    res.Add("errors", new JArray());
                    res.Add("success", true);
                    return res;
                }
                var res2 = new JObject();
                res2.Add("result", j);
                res2.Add("errors", new JArray("Couldn't convert percent to decimal percent value: " + j.ToString() + "!"));
                res2.Add("success", false);
                return res2;
            }
            public static JObject humus_to_corg(object root, JArray j)
            {
                if (j != null && j.Count == 2 && is_int(j[1] as JValue))
                {
                    var res = new JObject();
                    res.Add("result", SoilIO.humus_class_to_corg((int)j[1]));
                    res.Add("errors", new JArray());
                    res.Add("success", true);
                    return res;
                }
                var res2 = new JObject();
                res2.Add("result", j);
                res2.Add("errors", new JArray("Couldn't convert humus level to corg: " + j.ToString() + "!"));
                res2.Add("success", false);
                return res2;
            }
            private static bool is_int(JValue value)
            {
                if (value == null)
                    return false;
                return value.Type == JTokenType.Integer;
            }
            private static bool is_float(JValue value)
            {
                if (value == null)
                    return false;
                return value.Type == JTokenType.Float;
            }
            public static JObject GetValue(string function, object root, object j)
            {
                switch (function)
                {
                    case "include-from-file":
                        return from_file(root as JObject, j as JArray);
                    case "ref":
                        return @ref(root as JObject, j as JArray);
                    case "humus_st2corg":
                        return humus_to_corg(root as JObject, j as JArray);
                    case "ld_eff2trd":
                        return ld_to_trd(root as JObject, j as JArray);
                    case "bulk-density-class->raw-density":
                        return ld_to_trd(root as JObject, j as JArray);
                    case "KA5TextureClass2clay":
                        return ka5_to_clay(root as JObject, j as JArray);
                    case "KA5-texture-class->clay":
                        return ka5_to_clay(root as JObject, j as JArray);
                    case "KA5TextureClass2sand":
                        return ka5_to_sand(root as JObject, j as JArray);
                    case "KA5-texture-class->sand":
                        return ka5_to_sand(root as JObject, j as JArray);
                    case "sandAndClay2lambda":
                        return sand_clay_to_lambda(root as JObject, j as JArray);
                    case "sand-and-clay->lambda":
                        return sand_clay_to_lambda(root as JObject, j as JArray);
                    case "%":
                        return percent(root as JObject, j as JArray);
                    default:
                        throw new Exception("invalid pattern name!");
                }
            }
            public static bool Contains(string function)
            {
                switch (function)
                {
                    case "include-from-file":
                    case "ref":
                    case "humus_st2corg":
                    case "ld_eff2trd":
                    case "bulk-density-class->raw-density":
                    case "KA5TextureClass2clay":
                    case "KA5-texture-class->clay":
                    case "KA5TextureClass2sand":
                    case "KA5-texture-class->sand":
                    case "sandAndClay2lambda":
                    case "sand-and-clay->lambda":
                    case "%":
                        return true;
                    default:
                        return false;
                }
            }
        }
    }
}
