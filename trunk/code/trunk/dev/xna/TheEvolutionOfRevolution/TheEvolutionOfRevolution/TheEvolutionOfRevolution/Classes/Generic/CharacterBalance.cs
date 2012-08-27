using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheEvolutionOfRevolution
{
    public static class CharacterBalance
    {
        public static float q = 5.25f;
        public static float mariaHP = 85 * q;
        public static float mariaAttack = 0.87f;
        public static float mariaRange = 0;
        public static float mariaVelocity = 0.3f;
        public static float mariaDelay = 0.7f * q/3;

        public static float luizHP = 210f * q;
        public static float luizAttack = 1f;
        public static float luizRange = 5f;
        public static float luizVelocity = 0.32f;
        public static float luizDelay = 1.4f * q/3;

        public static float soldado_01HP = 150f * q;
        public static float soldado_01Attack = 1f;
        public static float soldado_01Range = 5f;
        public static float soldado_01Velocity = 0.60f;
        public static float soldado_01Delay = 1.2f * q/3;

        public static float dantonHP = 50 * q;
        public static float dantonAttack = 0.33f;
        public static float dantonRange = 200f;
        public static float dantonVelocity = 0.32f;
        public static float dantonDelay = 0.35f * q/3;

        public static float maratHP = 115 * q;
        public static float maratAttack = 0.87f;
        public static float maratRange = 0f;
        public static float maratVelocity = 0.30f;
        public static float maratDelay = 1 * q/3;

        public static float robespierreHP = 125 * q;
        public static float robespierreAttack = 2.5f;
        public static float robespierreRange = 0f;
        public static float robespierreVelocity = 0.46f;
        public static float robespierreDelay = 1 * q/3;
    }
}