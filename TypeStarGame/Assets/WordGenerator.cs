using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{

    string[] easyWords = { "Sun", "Rock", "Moon", "Cheese",
                           "Star", "Mars", "Of", "The",
                           "Laser", "Rocket", "Alien", "Robot",
                           "Earth", "Pluto", "Saturn", "Venus",
                           "Hubble", "Gravity", "Apollo", "Meteor",
                           "Galaxy", "Drax", "Thanos", "Punch"};

    string[] mediumWords = { "spaceship", "Supernova", "Inertia", "Mercury",
                             "Jupiter", "Sputnik", "Nebula", "Uranus",
                             "Predator", "Kepler", "Pokemon", "Kuiper",
                             "Challenger", "Discovery", "Millenium", "Armstrong",
                             "Quasar", "Light-year", "Guardians", "Martian",
                             "Kal-El", "Destroyer", "gauntlet", "Falcun"};

    string[] difficultWords = { "Entropy", "Constellation", "Astronomy", "Astrology",
                                "Magnetron", "Xenomorph", "Kryptoniter", "",
                                "Astronaut", "Galileo", "Enterprise", "Pathfinder",
                                "Andromeda", "Astrophysics", "Celestial", "Heliocentric",
                                "Interstellar", "Syzygy", "Transneptunian", "Rocket Raccoon",
                                "Frustum"};


    public string EasyRandomWords()
    {
        int ranIndexEasy = Random.Range(0, easyWords.Length);

        string easyRandom = easyWords[ranIndexEasy];

        return easyRandom;
    }

    public string MediumRandomWords()
    {
        int ranIndexMedium = Random.Range(0, mediumWords.Length);

        string mediumRandom = mediumWords[ranIndexMedium];

        return mediumRandom;
    }

    public string HardRandomWords()
    {
        int ranIndexDifficult = Random.Range(0, difficultWords.Length);

        string difficultRandom = difficultWords[ranIndexDifficult];

        return difficultRandom;
    }

}

