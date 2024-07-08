namespace GameClass
{
    public class Game
    {
        private Ping ping;
        private Pong pong;

        public Game()
        {
            ping = new Ping();
            pong = new Pong(ping);
            ping.setPong();
        }

        private void MoveElement(ref MovePingPong attack, ref MovePingPong defend)
        {
            MovePingPong tempAttack = attack;
            attack = defend;
            defend = tempAttack;
        }
        private void showWinner()
        {
            if (ping.Point > pong.Point)
                Console.WriteLine("Ping WINNER!");
            else if (ping.Point < pong.Point)
                Console.WriteLine("Pong WINNER!");
            else
                Console.WriteLine("Draw!");
        }
        public void startGame()
        {
            MovePingPong attack = ping.move;
            MovePingPong defend = pong.move;

            while (true)
            {
                if (attack() == false)
                    break;

                if (defend() == false)
                    break;

                MoveElement(ref attack, ref defend);
            }

            showWinner();


        }


        private delegate bool MovePingPong();
    }
}
