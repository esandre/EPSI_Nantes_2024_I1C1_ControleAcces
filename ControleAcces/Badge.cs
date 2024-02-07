namespace ControleAcces
{
    public class Badge
    {
        public bool EstBloqué { get; }

        private Badge(bool estBloqué)
        {
            EstBloqué = estBloqué;
        }

        private static Badge BadgeBloqué { get; } = new (true);
        private static Badge BadgeNonBloqué { get; } = new (false);
    }
}
