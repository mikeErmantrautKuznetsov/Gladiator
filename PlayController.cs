namespace GladiatorFights
{
    public class PlayController
    {
        private readonly ListCharacters _listCharacters = new ListCharacters();
        private readonly SkillTree _skillTree = new SkillTree();
        private readonly FightOnArena _fighterInArena = new FightOnArena();
        private readonly DisplaySuperPower _displaySuperPower = new DisplaySuperPower();

        public void ListFighter()
        {
            _listCharacters.Display();
        }

        public void ChoiceFighter(int key)
        {
            if (_listCharacters.TryGetFighter(key, out DataFighter fighterFirst))
            {
                _fighterInArena.Add(key, fighterFirst);
                _skillTree.Character(key);
                _displaySuperPower.Display(key);
            }
        }

        public void Fight(int firstCharacter, int secondCharacter)
        {
            _fighterInArena.TakeDamage(firstCharacter, secondCharacter);
            _fighterInArena.DisplayResult(firstCharacter, secondCharacter);
            _fighterInArena.Clear();
            Console.Clear();
            _listCharacters.Display();
        }
    }
}
