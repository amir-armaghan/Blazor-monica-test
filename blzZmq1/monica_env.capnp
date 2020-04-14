@0xf253d7dee180e59a;

using Cxx = import "c++.capnp";
$Cxx.namespace("mas::rpc");

struct Monica {

  interface Env {
    # an interface to create a MONICA Env from sim, crop, site.json

    create @0 (sim :Text, crop :Text, site :Text) -> (env :Text);
    # create the env from the 3 params
  }
}
