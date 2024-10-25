using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Flexus.ParticleMapEditor
{
    public interface IMapConfig
    {
        void SetMap(MapArgs args);

        public struct MapArgs
        {
            public ResourceTypeArgs[] UsedResourceConfigs;

            public byte[] ResourceConfigIndexes;
            public Vector2[] ResourcePositions;
            public float[] ResourceRotations;
            public float[] ResourceScales;
            public float[] ResourceHeights;

            public struct ResourceTypeArgs
            {
                public IResourceConfig Resource;
                public int Capacity;
                public int Level;
            }
        }
    }
}