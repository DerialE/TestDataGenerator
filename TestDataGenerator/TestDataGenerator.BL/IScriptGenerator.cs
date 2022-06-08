using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDataGenerator.Data;

namespace TestDataGenerator.BL
{
    
    public interface IScriptGenerator
    {
        /// <Note>
        /// We are strarting our project from designing this interface
        /// </Note>
        /// 
        UserEntity GenerateUser();
        string GetValueLine(UserEntity entity);
        string GetHeaderLine();
        string CreateScript(int entityCount);
    }
}
