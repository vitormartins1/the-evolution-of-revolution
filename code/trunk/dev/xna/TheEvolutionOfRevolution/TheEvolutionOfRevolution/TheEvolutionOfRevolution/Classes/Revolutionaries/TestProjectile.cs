using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Net;
using Microsoft.Xna.Framework.Storage;

namespace TheEvolutionOfRevolution
{
    class TestProjectile : StaticGameObject
    {
        //Character target;

        //private Vector2 posicao;            // posicao da flecha
        private float angulo;               // angulo de lançamento da flecha
        //private float orientacao;           // orientacao da flecha
        private Vector2 vetor;              // vetor de direcao da flecha
        private float velocidade;           // velocidade
        private float gravidade;            // gravidade

        public TestProjectile(Texture2D image, Vector2 position)
            : base(position, image, new Point(13, 13))
        {
            //this.target = target;
            gravidade = 0.05f;
            angulo = 40 * (float)Math.PI / 180; // Convertando o angulo em graus para radianos
            velocidade = 3.0f;
            vetor = new Vector2();
            vetor.X = velocidade * (float)Math.Cos(angulo);
            vetor.Y = velocidade * (float)-Math.Sin(angulo);
        }

        public void Update()
        {
            // Calculo da próxima posição
            Vector2 novaPosicao = new Vector2();
            novaPosicao.X = base.position.X - vetor.X;
            novaPosicao.Y = base.position.Y + vetor.Y;
            // Somando a gravidade em Y
            vetor.Y = vetor.Y + gravidade;
            // Colocando uma resistencia do ar na flecha
            //Vector2 resistenciaAr = new Vector2();
            //resistenciaAr.X = 0.01f * (float)Math.Cos(orientacao);
            //resistenciaAr.Y = 0.01f * (float)-Math.Sin(orientacao);
            // Subtraindo a resistencia do ar do nosso vetor direcao
            //vetor.X = vetor.X - resistenciaAr.X;
            //vetor.Y = vetor.Y + resistenciaAr.Y;
            // Verificando a orientacao da flecha
            //orientacao = (float)Math.Atan2(novaPosicao.Y - base.position.Y,
              //  novaPosicao.X - base.position.X);
            // Atribuindo a nova posição a posição da flecha
            base.position = novaPosicao;
        }
    }
}
