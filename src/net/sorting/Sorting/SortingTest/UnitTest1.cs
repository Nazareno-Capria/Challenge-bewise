using Sorting;
using System;

namespace SortingClassTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
    public void sort1Completo()
        {
            Jugador p1 = new Jugador("Matias", 100);
            Jugador p2 = new Jugador("Alejandro", 100);
            Jugador p3 = new Jugador("Enzo", 50);
            Jugador p4 = new Jugador("Junior", 75);
            Jugador p5 = new Jugador("Pablo", 150);
            List<Jugador> jugadores = new List<Jugador>();
            jugadores.Add(p1);
            jugadores.Add(p2);
            jugadores.Add(p3);
            jugadores.Add(p4);
            jugadores.Add(p5);
            List<Jugador> jugadoresResult = SortingClass.OrdenarPorPuntuacionYNombre(jugadores);

            Jugador p1Sort = new Jugador("Pablo", 150);
            Jugador p2Sort = new Jugador("Alejandro", 100);
            Jugador p3Sort = new Jugador("Matias", 100);
            Jugador p4Sort = new Jugador("Junior", 75);
            Jugador p5Sort = new Jugador("Enzo", 50);
            List<Jugador> jugadoresSort = new List<Jugador>();
            jugadoresSort.Add(p1Sort);
            jugadoresSort.Add(p2Sort);
            jugadoresSort.Add(p3Sort);
            jugadoresSort.Add(p4Sort);
            jugadoresSort.Add(p5Sort);

            Assert.That(jugadoresResult.Count(), Is.EqualTo(jugadoresSort.Count()));
            Assert.That(jugadoresResult[0].GetNombre(), Is.EqualTo(jugadoresSort[0].GetNombre()));
            Assert.That(jugadoresResult[1].GetNombre(), Is.EqualTo(jugadoresSort[1].GetNombre()));
            Assert.That(jugadoresResult[2].GetNombre(), Is.EqualTo(jugadoresSort[2].GetNombre()));
            Assert.That(jugadoresResult[3].GetNombre(), Is.EqualTo(jugadoresSort[3].GetNombre()));
            Assert.That(jugadoresResult[4].GetNombre(), Is.EqualTo(jugadoresSort[4].GetNombre()));

            jugadores = new List<Jugador>();
            jugadoresResult = SortingClass.OrdenarPorPuntuacionYNombre(jugadores);
            Assert.True(!jugadoresResult.Any());

            jugadores = new List<Jugador>();
            jugadores.Add(p1);
            jugadoresResult = SortingClass.OrdenarPorPuntuacionYNombre(jugadores);
            Assert.That(jugadoresResult.Count(), Is.EqualTo(1));
            Assert.That(jugadoresResult[0].GetNombre(), Is.EqualTo(p1.GetNombre()));
        }

        [Test]
    public void sort1Vacio()
        {
            List<Jugador> jugadores = new List<Jugador>();
            List<Jugador> jugadoresResult = SortingClass.OrdenarPorPuntuacionYNombre(jugadores);
            Assert.True(!jugadoresResult.Any());
        }

        [Test]
    public void sort1Unico()
        {
            Jugador p1 = new Jugador("Matias", 100);
            List<Jugador> jugadores = new List<Jugador>();
            jugadores.Add(p1);
            List<Jugador> jugadoresResult = SortingClass.OrdenarPorPuntuacionYNombre(jugadores);
            Assert.That(jugadoresResult.Count(), Is.EqualTo(1));
            Assert.That(jugadoresResult[0].GetNombre(), Is.EqualTo(p1.GetNombre()));
        }

        [Test]
        public void sort2Completo()
        {

            Jugador p1 = new Jugador("Matias", 100, 3);
            Jugador p2 = new Jugador("Alejandro", 100, 4);
            Jugador p3 = new Jugador("Enzo", 75, 5);
            Jugador p4 = new Jugador("Junior", 75, 30);
            Jugador p5 = new Jugador("Pablo", 150, 0);
            List<Jugador> jugadores = new List<Jugador>();
            jugadores.Add(p1);
            jugadores.Add(p2);
            jugadores.Add(p3);
            jugadores.Add(p4);
            jugadores.Add(p5);

            List<Jugador> jugadoresResult = SortingClass.OrdenarPorPuntuacionPerdidasYNombre(jugadores);

            Jugador p1Sort = new Jugador("Pablo", 150, 0);
            Jugador p2Sort = new Jugador("Matias", 100, 3);
            Jugador p3Sort = new Jugador("Alejandro", 100, 4);
            Jugador p4Sort = new Jugador("Enzo", 75, 5);
            Jugador p5Sort = new Jugador("Junior", 75, 30);

            List<Jugador> jugadoresSort = new List<Jugador>();
            jugadoresSort.Add(p1Sort);
            jugadoresSort.Add(p2Sort);
            jugadoresSort.Add(p3Sort);
            jugadoresSort.Add(p4Sort);
            jugadoresSort.Add(p5Sort);


            Assert.That(jugadoresResult.Count(), Is.EqualTo(jugadoresSort.Count()));
            Assert.That(jugadoresResult[0].GetNombre(), Is.EqualTo(jugadoresSort[0].GetNombre()));
            Assert.That(jugadoresResult[1].GetNombre(), Is.EqualTo(jugadoresSort[1].GetNombre()));
            Assert.That(jugadoresResult[2].GetNombre(), Is.EqualTo(jugadoresSort[2].GetNombre()));
            Assert.That(jugadoresResult[3].GetNombre(), Is.EqualTo(jugadoresSort[3].GetNombre()));
            Assert.That(jugadoresResult[4].GetNombre(), Is.EqualTo(jugadoresSort[4].GetNombre()));
        }

        [Test]
        public void sort2Vacio()
        {
            List<Jugador> jugadores = new List<Jugador>();
            List<Jugador> jugadoresResult = SortingClass.OrdenarPorPuntuacionPerdidasYNombre(jugadores);
            Assert.True(!jugadoresResult.Any());
        }

        [Test]
        public void sort2Unico()
        {
            Jugador p1 = new Jugador("Matias", 100);
            List<Jugador> jugadores = new List<Jugador>();
            jugadores.Add(p1);
            List<Jugador> jugadoresResult = SortingClass.OrdenarPorPuntuacionPerdidasYNombre(jugadores);
            Assert.That(jugadoresResult.Count(), Is.EqualTo(1));
            Assert.That(jugadoresResult[0].GetNombre(), Is.EqualTo(p1.GetNombre()));
        }
    }
}