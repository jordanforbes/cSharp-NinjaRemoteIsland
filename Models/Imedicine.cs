using System;

namespace cSharp_NinjaRemoteIsland.Models {
    public interface IMedicine
    {
        string Name {get;set;}

        void Use(Hero target);

        void Use(Villain target);
    }
}