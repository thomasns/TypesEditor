using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
namespace TerrainTypeBuilder
{
    public class TerrainType
    {
        public string Type { get; set; }

        //ToDo think about how to actually do sprites 
        public int spriteX { get; set; }
        public int spriteY { get; set; }
        public int spriteSize { get; set; }
        public bool impassable { get; set; }
        public bool animaited { get; set; }
        public List<int> animationSequence { get; set; }

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
                this.animationSequence = new List<int>(original.animationSequence.Count());
                foreach (int i in original.animationSequence)
                    animationSequence.Add(i);
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