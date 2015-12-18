using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntGame_v2.Model.Unit
{
    class Storage : Building
    {
        Dictionary<string, int> _resources { get; set; }//При создании экземпляра класса Муравейник, необходимо в его констркторе заполнить словарь resources четко прописанными видами ресурсов
        
        public int GetResource(string res)
        {
           return this._resources[res].Value;
        }
        
        public void UpResource(string res, int count)
        {
            if(this._resources[res] + count > buildingLevel * 100)//От уровня зависит вместимость хранилища
              this._resources[res] = buildingLevel * 100;
            else
              this._resources[res] += count;
        }
        
        public void DownResource(string res, int count)
        {
            if(this._resources[res] - count < 0)
              this._resources[res] = 0;
            else 
              this._resources[res] -= count;
        }
    }
}
