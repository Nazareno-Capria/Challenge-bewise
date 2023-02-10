// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;

void Main(string[] arg)
{
}

public class RepeatedCharacters
{
    /**
     * El metodo debe retornar un booleano indicando si el parametro `cadena` cumple con alguna de las siguientes propiedades:
     * 1- Todos los caracteres aparecen la misma cantidad de veces.
     * Ejemplos: "aabbcc", "abcdef", "aaaaaa"
     * 2- Todos los caracteres aparecen la misma cantidad de veces, a excepcion de 1, que aparece un vez mas o una vez menos.
     * Ejemplos: "aabbccc", "aabbc", "aaaaccccc"
     *
     * @param cadena la cadena a evaluar
     * @return booleano indicando si la cadena cumple con las propiedades
     */
    public bool isValid(string cadena)
    {
        char[] charsFound = new char[cadena.Length];
        int[] charQuantity = new int[cadena.Length];
        Dictionary<char, int> charDictionary = new Dictionary<char, int>();

        for (int i = 0; i < cadena.Length; i++)
        {
            if (!charDictionary.ContainsKey(cadena[i]) && cadena[i] != ' ')
            {
                charDictionary.Add(cadena[i], 1);
            }
            else if (cadena[i] != ' ')
            {
                charDictionary.TryGetValue(cadena[i], out int val);
                charDictionary[cadena[i]] = val + 1;
            }
        }
        //danger = YA se encontró un caracter con una repitencia no mayor a 1, por ende si hay otro no es valido.
        bool danger = false;
        int times = 0;
        bool isValid = true;
        foreach(char c in charDictionary.Keys)
        {
            if(times == 0)
            {
                charDictionary.TryGetValue(c, out int value);
                times = value;
            }
            else
            {
                charDictionary.TryGetValue(c, out int value);
                if(times > value && !danger)
                {
                    if (times - value > 1)
                    {
                        return false;
                    }
                    else if(times - value == 1)
                    {
                        danger = true;
                    }
                }
                else if (times < value && !danger)
                {
                    if (value - times > 1)
                    {
                        return false;
                    }
                    else if (value - times == 1)
                    {
                        danger = true;
                    }
                }
                else if((times > value || value > times) && danger)
                {
                    isValid = false;
                }
            }
        }
        return isValid;
    }
}