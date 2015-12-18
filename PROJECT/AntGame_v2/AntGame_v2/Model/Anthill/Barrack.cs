using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntGame_v2.Model.Unit
{
    class Barrack : Building
    {
        _int antCount;//Количество муравьев в муравейнике. Надо определиться, где учет всех обьектов ведется. Лимит муравьев зависит от уровня казармы
        
        public Barrack()
        {
          antCount = 0;
        }
        
        public void CreateAnt(Unit unit)
        {
          antCount = GetCountAnt();
          if( (MONEY >= 25) && (antCount < buildingLevel * 7)) {//На первом уровне лимит в 7 муравьев. С каждым уровнем приращение по 7.
            //TODO: Созжание муравья определенного вида и списание ресурсов (стоимость одного муравья 25 едениц)
          }
        }
        
        public int GetCountAnt()
        {
          //TODO: Откуда можем получить ответ на вопрос:"Сколько муравьев в муравейнике?"
          //return count;
        }
    }
}
