using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_Of_Us_Editor.LevelComponents
{
    public class CurrentLevelComponets
    {
        // Varibles
        public string compiledLevel = "", levelSave = "";

        public void saveLevel(string _currentLevel)
        {
            levelSave = _currentLevel;
        }

        public void compileLevel()
        {
            compiledLevel = levelSave;
        }
    }
}
