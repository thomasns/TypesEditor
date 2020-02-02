using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrainTypeBuilder
{
    class TerrainType
    {
        public string Type { get; set; }

        //ToDo think about how to actually do sprites 
        public int spriteX { get; set; }
        public int spriteY { get; set; }
        public int spriteSize { get; set; }
        public bool impassable { get; set; }
        public bool animaited { get; set; }
        public int[] animationSequence { get; set; }

        public int movementCost { get; set; }

        public TerrainType()
        {
            this.Type = "new type";
            this.spriteX = 0;
            this.spriteY = 0;
            this.spriteSize = 15;
            this.impassable = false;
            this.animaited = false;
            this.animationSequence = null;
            this.movementCost = 1;
        }

        public TerrainType(TerrainType original)
        {
            this.Type = original.Type;
            this.spriteX = original.spriteX;
            this.spriteY = original.spriteY;
            this.spriteSize = original.spriteSize;
            this.impassable = original.impassable;
            this.animaited = original.animaited;
            if (animaited) {
                this.animationSequence = new int[original.animationSequence.Count()];
                for (int i = 0; i < animationSequence.Count(); i++)
                    animationSequence[i] = original.animationSequence[i];
            }
            this.animationSequence = original.animationSequence;
            this.movementCost = original.movementCost;
        }

        public override String ToString()
        {
            return this.Type;
        }
        


    }
}