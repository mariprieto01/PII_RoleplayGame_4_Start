using System;
using System.Collections.Generic;
using RoleplayGame.Encounters;
using RoleplayGame.Characters;
using RoleplayGame.Items;
using RoleplayGame.Scenarios;

namespace Program
{

    public class TestScenario : IScenario
    {
        private List<Character> characters = new List<Character>();

        public void Setup()
        {
            Giant giant = new Giant("Giant");
            Minotaur Minotaur = new Minotaur("Minotaur");
            Archer archer = new Archer("Archer");
            Elf elf = new Elf("Elf");
            Dwarf dwarf = new Dwarf("Dwarf");

            characters.Add(giant);
            characters.Add(Minotaur);
            characters.Add(archer);
            characters.Add(elf);
            characters.Add(dwarf);

            foreach (Character character in characters)
            {
                character.AddItems(new List<IItem>(new IItem[] { ItemFactory.GetRandomItem(), ItemFactory.GetRandomItem() }));
            }
        }

        public void Run()
        {
            AttackEncounter encounterOne = EncounterFactory.GetEncounter(EncounterType.Attack, characters[0], characters[1]) as AttackEncounter;
            encounterOne.Reporter = new ConsoleReporter();
            encounterOne.DoEncounter();
            Character EnconunterOneWinner = encounterOne.DecideWinner();
            EnconunterOneWinner.HelthItself();

            AttackEncounter encounterTwo = EncounterFactory.GetEncounter(EncounterType.Exchange, characters[2], characters[3]) as AttackEncounter;
            encounterTwo.Reporter = new ConsoleReporter();
            encounterTwo.DoEncounter();
            Character EnconunterTwoWinner = encounterTwo.DecideWinner();
            EnconunterOneWinner.HelthItself();


            AttackEncounter encounterThree = EncounterFactory.GetEncounter(EncounterType.Exchange, EnconunterOneWinner, EnconunterTwoWinner) as AttackEncounter;
            encounterThree.Reporter = new ConsoleReporter();
            encounterThree.DoEncounter();
            Character EnconunterThreeWinner = encounterThree.DecideWinner();
            EnconunterOneWinner.HelthItself();


            AttackEncounter Final = EncounterFactory.GetEncounter(EncounterType.Attack, EnconunterThreeWinner, characters[4]) as AttackEncounter;
            Final.Reporter = new ConsoleReporter();
            Final.DoEncounter();
            Character FinalWinner = Final.DecideWinner();
            EnconunterOneWinner.HelthItself();

            Console.WriteLine("The winner is: " + FinalWinner.Name);
        }
    }
}