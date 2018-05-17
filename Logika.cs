using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cezar
{
    class Logika
    {
        char[] Litery = { 'a', 'ą', 'b', 'c', 'ć', 'd', 'e', 'ę', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'ł', 'm', 'n', 'ń', 'o', 'ó', 'p', 'r', 's', 'ś', 't', 'u', 'w', 'y', 'z', 'ż', 'ź' };

        public string szyfruj(String wiadomosc, int przesuniecie)
        {
            String szyfr = "";
            wiadomosc = wiadomosc.ToLower();
            char[] znaki = wiadomosc.ToCharArray();

            for(int i=0; i<znaki.Length; i++)
            {
            	bool spojniki=false;
            	
                for(int j=0; j<Litery.Length; j++)
                {                		
                    if (znaki[i].Equals(Litery[j]))
                    {
                    	int x=j + przesuniecie;
                    	if(x>=Litery.Length)
                    		x=przesuniecie-(Litery.Length-j);
                    		
                        char znak = Litery[x];
                        szyfr += znak;
                        spojniki=true;
                    }
                }
                if(spojniki==false)
                	szyfr+=znaki[i];
            }

            return szyfr;
        }
        
        public string deszyfruj(String szyfr, int przesuniecie)
        {
            String wiadomosc = "";
            szyfr = szyfr.ToLower();
            char[] znaki = szyfr.ToCharArray();

            for(int i=0; i<znaki.Length; i++)
            {
            	bool spojniki=false;
            	
                for(int j=0; j<Litery.Length; j++)
                {                		
                    if (znaki[i].Equals(Litery[j]))
                    {
                    	int x=j - przesuniecie;
                    	if(x<0)
                    		x=Litery.Length-przesuniecie+j;
                    		
                        char znak = Litery[x];
                        wiadomosc += znak;
                        spojniki=true;
                    }
                }
                if(spojniki==false)
                	wiadomosc+=znaki[i];
            }

            return wiadomosc;
        }
    }
}
