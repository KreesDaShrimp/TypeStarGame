using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordGenerator : MonoBehaviour
{
    private int currentLevel;
    string[] easyWords = { "sun", "rock", "moon", "cheese",
                           "star", "Mars", "of", "the",
                           "laser", "rocket", "alien", "robot",
                           "Earth", "Pluto", "Saturn", "Venus",
                           "hubble", "gravity", "Apollo", "meteor",
                           "galaxy", "drax", "Thanos", "punch" ,
                           "black","hole","cosmic","ray",
                            "cosmos","crater","comet","red",
                            "circle","round","bright","dark",
                            "empty","open","space","outer",
                            "deep","day","night","dawn",
                            "dusk","cloud","blue","sound",
                            "void","white","green","orange",
                            "north","south","east","west",
                            "pilot","pod","polar","oxygen",
                            "osiris","rain","snow","halo",
                            "Groot","giant","libra","draco"};

    string[] mediumWords = { "spaceship", "supernova", "inertia", "Mercury",
                             "Jupiter", "Sputnik", "bebula", "Uranus",
                             "predator", "kepler", "Pokemon", "kuiper",
                             "challenger", "discovery", "millenium", "Armstrong",
                             "quasar", "light-year", "guardians", "Martian",
                             "Kal-El", "destroyer", "gauntlet", "falcon",
                             "density","eclipse","velocity","collide",
                             "horizon","gravity","helium","hydrogen",
                             "orbit","sidereal","twinkle","little",
                             "science","infinity","beyond","vacuum",
                             "bolide","bolometer","cehpeid","clusters",
                             "element","ozone","perigee","phases",
                             "shuttle","tempest","torpedo","twilight",
                             "universe","zodiac","autobots","Avengers",
                             "barrier","blockade","captain","centauri",
                             "citadel","blitzar","fighter","frontier"};

    string[] difficultWords = { "entropy", "constellation", "Astronomy", "Astrology",
                                "magnetron", "Xenomorph", "Kryptoniter", "exoplanet",
                                "astronaut", "Galileo", "enterprise", "pathfinder",
                                "Andromeda", "Astrophysics", "celestial", "heliocentric",
                                "Interstellar", "syzygy", "transneptunian", "Rocket-Raccoon",
                                "frustum","equinox","earthbound","extragalactic",
                                "hypernova","telescope","magnitude","meteorite",
                                "observatory","opposition","occultation","satellite",
                                "telemetry","terrestrial","wavelength","wormhole",
                                "interplanetary","pressureless","spacecraft","Milkyway",
                                "Solar-System","gamma-ray","Acceleration","Atmosphere",
                                "barycentre","conjunction","coronagraph","ecosphere",
                                "parallax","perturbations","turbulence","photosphere",
                                "scintillation","selenography","solstice","stratosphere",
                                "sundial","Terminator","thermocouple","troposphere",
                                "antimatter","futuristic","interdimensional","circumlunar",
                                "Sagittarius","sovereign","stormbreaker","tesseract",
                                "transmission","xenoarchaeology","starfield","destination",
                                "extraterrestrial","exploration","engineering","discovery",
                                "gyroscope","harbinger","helioseismology","longitude"};
    //"","","",""
    string displayedText;
    Text textBox;
    public int count;

    private void Start()
    {
        currentLevel = LevelData.GetLevel();
        //currentLevel = 1;

        textBox = GetComponent<Text>();
        if (currentLevel == 1)
        {
            displayedText = EasyRandomWords();      
        }
        else if (currentLevel == 2)
        {
            displayedText = MediumRandomWords();
        }
        else
        {
            displayedText = HardRandomWords();
        }
        textBox.text = displayedText;
    }

    private void Update()
    {
        // displayedText = HardRandomWords();
        // textBox.text = displayedText;
    }

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

