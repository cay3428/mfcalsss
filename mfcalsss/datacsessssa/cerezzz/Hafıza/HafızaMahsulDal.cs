using datacsessssa.ana;
using System;
using System.Collections.Generic;
using System.Text;
using varlıksss.cerezz;

namespace datacsessssa.cerezzz.Hafıza
{
    public class HafızaMahsulDal : ImahsulDal
       
    {
        List<mahsul> _mahsuls;
        public HafızaMahsulDal()
        {
            _mahsuls = new List<mahsul> {
              new mahsul { mahsulId = 1, ulamId = 1, Mahsuladı = "hıyar", mahsulFiyat = 15, yığılım = 15 },
             new mahsul { mahsulId = 2, ulamId = 11 , Mahsuladı ="incir", mahsulFiyat=30,yığılım =15 } ,
             new mahsul { mahsulId = 3, ulamId = 10 , Mahsuladı ="nektari", mahsulFiyat=60,yığılım =15 } ,
             new mahsul { mahsulId = 4, ulamId = 9 , Mahsuladı ="ceviz", mahsulFiyat=80,yığılım =15 } ,
             new mahsul { mahsulId = 5, ulamId = 8 , Mahsuladı ="marul", mahsulFiyat=5,yığılım =15 } ,
             new mahsul { mahsulId = 6, ulamId = 7 , Mahsuladı ="limon", mahsulFiyat=9,yığılım =15 } ,





             };
 }

        public void Ekle(mahsul mahsul)
        {
            throw new NotImplementedException();
        }

        public List<mahsul> getAll()
        {
            throw new NotImplementedException();
        }

        public void güncelle(mahsul mahsul)
        {
            throw new NotImplementedException();
        }

        public void yoket(mahsul mahsul)
        {
            throw new NotImplementedException();
        }
    }


     
    }


 