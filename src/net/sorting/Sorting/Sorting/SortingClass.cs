// See https://aka.ms/new-console-template for more information
using Sorting;
using System.Runtime.InteropServices;

void Main(string[] args)
{

}
public class SortingClass
{
    /**
     * Se debe ordenar primero por puntuación de manera descendente, luego por nombre de manera ascendente.
     *
     * @param jugadores la lista de jugadores a ordenar
     * @return la lista ordenada de jugadores
     */
    public static List<Jugador> OrdenarPorPuntuacionYNombre(List<Jugador> jugadores)
    {

        //List<Jugador> orderedPlayers = jugadores.OrderByDescending(p => p.GetPuntuacion()).ThenBy(p => p.GetNombre()).ToList();

        List<Jugador> orPlayers = new List<Jugador>(jugadores.Count);
        for (int i = 0; i < jugadores.Count; i++)
        {
            OrderPlayerByPointsAndName(jugadores[i], orPlayers);
        }
        return orPlayers;
    }

    /**
     * Se debe ordenar primero por puntuación de manera descendente. Cuando 2 jugadores tienen igual cantidad de puntos,
     * el que tiene menos perdidas se lo considerara el mayor. Luego a igual puntos y perdidas se segxxuirá usando el
     * nombre de manera ascendente.
     *
     * @param jugadores la lista de jugadores a ordenar
     * @return la lista ordenada de jugadores
     */
    public static List<Jugador> OrdenarPorPuntuacionPerdidasYNombre(List<Jugador> jugadores)
    {
        List<Jugador> orPlayers = new List<Jugador>(jugadores.Count);
        for (int i = 0; i < jugadores.Count; i++)
        {
            OrderPlayerByPointsLostsAndName(jugadores[i], orPlayers);
        }
        return orPlayers;
    }


    public static List<Jugador> OrderPlayerByPointsAndName(Jugador jugador, List<Jugador> orderedPlayers)
    {
        if (!orderedPlayers.Any())
        {
            orderedPlayers.Add(jugador);
            return orderedPlayers;
        }
        for (int i = 0; i < orderedPlayers.Count; i++)
        {
            if (orderedPlayers[i].GetPuntuacion() < jugador.GetPuntuacion()) 
            {
                orderedPlayers.Insert(i, jugador);
                break;
            }
            else if (orderedPlayers[i].GetPuntuacion() > jugador.GetPuntuacion())
            {
                if(orderedPlayers.Last() == orderedPlayers[i])
                {
                    orderedPlayers.Add(jugador);
                    break;
                }
                    
            }
            else if(orderedPlayers[i].GetPuntuacion()== jugador.GetPuntuacion())
            {
                int firstOrAfter = jugador.GetNombre().CompareTo(orderedPlayers[i].GetNombre());
                if (firstOrAfter > 0) 
                { 
                    orderedPlayers.Add(jugador);
                    break;
                }
                if (firstOrAfter < 0)
                {
                    orderedPlayers.Insert(i, jugador);
                    break;
                }
                else 
                { 
                    orderedPlayers.Add(jugador);
                    break;
                }
            }
        }
        return orderedPlayers;
    }
    public static List<Jugador> OrderPlayerByPointsLostsAndName(Jugador jugador, List<Jugador> orderedPlayers)
    {
        if (!orderedPlayers.Any())
        {
            orderedPlayers.Add(jugador);
            return orderedPlayers;
        }
        for (int i = 0; i < orderedPlayers.Count; i++)
        {
            if (orderedPlayers[i].GetPuntuacion() < jugador.GetPuntuacion())
            {
                orderedPlayers.Insert(i, jugador);
                break;
            }
            else if (orderedPlayers[i].GetPuntuacion() > jugador.GetPuntuacion())
            {
                if (orderedPlayers.Last() == orderedPlayers[i])
                {
                    orderedPlayers.Add(jugador);
                    break;
                }

            }
            else if (orderedPlayers[i].GetPuntuacion() == jugador.GetPuntuacion())
            {
                if (orderedPlayers[i].GetPerdidas() > jugador.GetPerdidas())
                {
                    orderedPlayers.Insert(i, jugador);
                    break;
                }
                else if (orderedPlayers[i].GetPerdidas() < jugador.GetPerdidas())
                {
                    if (orderedPlayers.Last() == orderedPlayers[i])
                    {
                        orderedPlayers.Add(jugador);
                        break;
                    }

                }
                else if (orderedPlayers[i].GetPerdidas() == jugador.GetPerdidas())
                {
                    int firstOrAfter = jugador.GetNombre().CompareTo(orderedPlayers[i].GetNombre());
                    if (firstOrAfter > 0)
                    {
                        orderedPlayers.Add(jugador);
                        break;
                    }
                    if (firstOrAfter < 0)
                    {
                        orderedPlayers.Insert(i, jugador);
                        break;
                    }
                    else
                    {
                        orderedPlayers.Add(jugador);
                        break;
                    }
                }
                
            }
        }
        return orderedPlayers;
    }
}