using UnityEngine;

namespace Assets.Scripts.Enemies
{

    internal class Enemies
    {
        //Variables
        [SerializeField]
        private int _iD;
        public int iD { get { return _iD; } set { _iD = value; } }

        [SerializeField]
        private string _type;
        public string type { get { return _type; } set { _type = value; } }

        [SerializeField]
        private int _Hp;
        public int hp { get { return _Hp; } set { _Hp = value; } }

        [SerializeField]
        private int _Mp;
        public int mp { get { return _Mp; } set { _Mp = value; } }

        [SerializeField]
        private TypeEnemy _Type;
        public TypeEnemy Type { get { return _Type; } set { _Type = value; } }


        [SerializeField]
        internal enum TypeEnemy
        {
            Samuai, Daimon, Ronin, Village, ShinsenGumi
        }

        //Methods





        //Fuctions
        internal virtual int BasicAtack(int Damage)
        {
            return _Hp;
        }
        internal virtual int DamageDone(int Damage)
        {
            return _Mp;
        }

    }

}
