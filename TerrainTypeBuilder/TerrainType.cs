using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
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

        public bool differentIfMatchingNeighbor { get; set; }
        public bool onlyMatchDirect { get; set; }
        [XmlIgnore]
        public Dictionary<int,Tuple<int,int>> neighborSprites { get; set; }
        public List<int> neighborSpritesList { get; set; }

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
            this.differentIfMatchingNeighbor = false;
        }

        public TerrainType(TerrainType original)
        {
            this.Type = original.Type;
            this.spriteX = original.spriteX;
            this.spriteY = original.spriteY;
            this.spriteSize = original.spriteSize;
            this.impassable = original.impassable;
            this.animaited = original.animaited;
            if (animaited)
            {
                this.animationSequence = new List<int>(original.animationSequence.Count());
                foreach (int i in original.animationSequence)
                    animationSequence.Add(i);
            }
            this.animationSequence = original.animationSequence;
            this.movementCost = original.movementCost;
            
            if(original.neighborSprites != null)
                this.neighborSprites = new Dictionary<int, Tuple<int, int>>(original.neighborSprites);
            else 
                this.neighborSprites = new Dictionary<int, Tuple<int, int>>();
        }

        public override String ToString()
        {
            return this.Type;
        }

        public static List<TerrainType> loadTypes(String path)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(List<TerrainType>));
            TextReader reader = new StreamReader(path);
            object obj = deserializer.Deserialize(reader);
            List<TerrainType> loadedTypes = (List<TerrainType>)obj;
            reader.Close();
            return loadedTypes;
        }

        public Tuple<int,int> getSpriteCoordinates(int matchingNeighbors)
        {
            if (!differentIfMatchingNeighbor)
                return new Tuple<int, int>(spriteX, spriteY);
            else
            {
                return new Tuple<int, int>(spriteX, spriteY);
            }
        }

        public void setSpriteForNeighbors(int value)
        {
            if(neighborSprites.ContainsKey(value))
            {
                this.spriteX = neighborSprites[value].Item1;
                this.spriteY = neighborSprites[value].Item2;

            }
            

        }
        public Tuple<int,int> getSpriteLocation(int value)
        {
            if(differentIfMatchingNeighbor)
            {
                if (neighborSprites.ContainsKey(value))
                    return neighborSprites[value];
            }
            return new Tuple<int, int>(spriteX, spriteY);
        }

        public void prepForSerilization()
        {
            neighborSpritesList = new List<int>();
            foreach (KeyValuePair<int, Tuple<int, int>> kvp in neighborSprites)
            {
                neighborSpritesList.Add(kvp.Key);
                neighborSpritesList.Add(kvp.Value.Item1);
                neighborSpritesList.Add(kvp.Value.Item2);
            }
        }

        public  void setUpSpriteDictionary()
        {
            if (neighborSpritesList != null)
            {
                neighborSprites = new Dictionary<int, Tuple<int, int>>();
                for (int i = 0; i < neighborSpritesList.Count(); i += 3)
                    neighborSprites.Add(neighborSpritesList[i], new Tuple<int, int>(neighborSpritesList[i + 1], neighborSpritesList[i + 2]));

                neighborSpritesList = null;
            }
        
        }


    }
}