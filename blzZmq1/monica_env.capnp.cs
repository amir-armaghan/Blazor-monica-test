using Capnp;
using Capnp.Rpc;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Mas.Rpc
{
    [TypeId(0xf688c6c2de9bf823UL)]
    public class Monica : ICapnpSerializable
    {
        public const UInt64 typeId = 0xf688c6c2de9bf823UL;
        void ICapnpSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
        }

        void ICapnpSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(0, 0);
            }
        }

        [TypeId(0xf90025d799426344UL), Proxy(typeof(Env_Proxy)), Skeleton(typeof(Env_Skeleton))]
        public interface IEnv : IDisposable
        {
            Task<string> Create(string sim, string crop, string site, CancellationToken cancellationToken_ = default);
        }

        public class Env_Proxy : Proxy, IEnv
        {
            public async Task<string> Create(string sim, string crop, string site, CancellationToken cancellationToken_ = default)
            {
                var in_ = SerializerState.CreateForRpc<Mas.Rpc.Monica.Env.Params_create.WRITER>();
                var arg_ = new Mas.Rpc.Monica.Env.Params_create()
                {Sim = sim, Crop = crop, Site = site};
                arg_.serialize(in_);
                var d_ = await Call(17942382523363517252UL, 0, in_.Rewrap<DynamicSerializerState>(), false, cancellationToken_).WhenReturned;
                var r_ = CapnpSerializable.Create<Mas.Rpc.Monica.Env.Result_create>(d_);
                return (r_.Env);
            }
        }

        public class Env_Skeleton : Skeleton<IEnv>
        {
            public Env_Skeleton()
            {
                SetMethodTable(Create);
            }

            public override ulong InterfaceId => 17942382523363517252UL;
            Task<AnswerOrCounterquestion> Create(DeserializerState d_, CancellationToken cancellationToken_)
            {
                var in_ = CapnpSerializable.Create<Mas.Rpc.Monica.Env.Params_create>(d_);
                return Impatient.MaybeTailCall(Impl.Create(in_.Sim, in_.Crop, in_.Site, cancellationToken_), env =>
                {
                    var s_ = SerializerState.CreateForRpc<Mas.Rpc.Monica.Env.Result_create.WRITER>();
                    var r_ = new Mas.Rpc.Monica.Env.Result_create{Env = env};
                    r_.serialize(s_);
                    return s_;
                }

                );
            }
        }

        public static class Env
        {
            [TypeId(0xa0f91a0d00aa3981UL)]
            public class Params_create : ICapnpSerializable
            {
                public const UInt64 typeId = 0xa0f91a0d00aa3981UL;
                void ICapnpSerializable.Deserialize(DeserializerState arg_)
                {
                    var reader = READER.create(arg_);
                    Sim = reader.Sim;
                    Crop = reader.Crop;
                    Site = reader.Site;
                    applyDefaults();
                }

                public void serialize(WRITER writer)
                {
                    writer.Sim = Sim;
                    writer.Crop = Crop;
                    writer.Site = Site;
                }

                void ICapnpSerializable.Serialize(SerializerState arg_)
                {
                    serialize(arg_.Rewrap<WRITER>());
                }

                public void applyDefaults()
                {
                }

                public string Sim
                {
                    get;
                    set;
                }

                public string Crop
                {
                    get;
                    set;
                }

                public string Site
                {
                    get;
                    set;
                }

                public struct READER
                {
                    readonly DeserializerState ctx;
                    public READER(DeserializerState ctx)
                    {
                        this.ctx = ctx;
                    }

                    public static READER create(DeserializerState ctx) => new READER(ctx);
                    public static implicit operator DeserializerState(READER reader) => reader.ctx;
                    public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                    public string Sim => ctx.ReadText(0, "");
                    public string Crop => ctx.ReadText(1, "");
                    public string Site => ctx.ReadText(2, "");
                }

                public class WRITER : SerializerState
                {
                    public WRITER()
                    {
                        this.SetStruct(0, 3);
                    }

                    public string Sim
                    {
                        get => this.ReadText(0, "");
                        set => this.WriteText(0, value, "");
                    }

                    public string Crop
                    {
                        get => this.ReadText(1, "");
                        set => this.WriteText(1, value, "");
                    }

                    public string Site
                    {
                        get => this.ReadText(2, "");
                        set => this.WriteText(2, value, "");
                    }
                }
            }

            [TypeId(0xd3d4f30c0a296d6bUL)]
            public class Result_create : ICapnpSerializable
            {
                public const UInt64 typeId = 0xd3d4f30c0a296d6bUL;
                void ICapnpSerializable.Deserialize(DeserializerState arg_)
                {
                    var reader = READER.create(arg_);
                    Env = reader.Env;
                    applyDefaults();
                }

                public void serialize(WRITER writer)
                {
                    writer.Env = Env;
                }

                void ICapnpSerializable.Serialize(SerializerState arg_)
                {
                    serialize(arg_.Rewrap<WRITER>());
                }

                public void applyDefaults()
                {
                }

                public string Env
                {
                    get;
                    set;
                }

                public struct READER
                {
                    readonly DeserializerState ctx;
                    public READER(DeserializerState ctx)
                    {
                        this.ctx = ctx;
                    }

                    public static READER create(DeserializerState ctx) => new READER(ctx);
                    public static implicit operator DeserializerState(READER reader) => reader.ctx;
                    public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                    public string Env => ctx.ReadText(0, "");
                }

                public class WRITER : SerializerState
                {
                    public WRITER()
                    {
                        this.SetStruct(0, 1);
                    }

                    public string Env
                    {
                        get => this.ReadText(0, "");
                        set => this.WriteText(0, value, "");
                    }
                }
            }
        }
    }
}