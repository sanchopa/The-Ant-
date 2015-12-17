using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntGame_v2.Model.Unit
{
    class Laboratory : Building //Свойство BuildingLevel не нужно лаборатории
    {
        Dictionary<string, bool> improvements { get; set; }//При создании экземпляра класса Лаборатория, необходимо в его констркторе заполнить словарь improvement четко прописанными видами улучшений

        public void Explore(string improvement)//Исследование происходит моментально, нужны лишь ресурсы на него (не будет таймера)
        {
            if( (this.improvements[improvement]  == false) && (MONEY >= 100)) {//Если false, значит не исследовано. Надо подумать, откуда брать информацию об текущем количестве ресурсов
              this.improvements[improvement] = true;
              //TODO: Здесь списываем 100 едениц ресурсов
              }
        }
        
        public bool GetImprovement(string imp)
        {
           return this.improvements[res].Value;
        }
    }
}
