namespace SingletonVault
{
    internal class Vault
    {
        private readonly string _secretKey;
        private static Vault? _vault;
        private static object _lock = new object();

        private Vault()
        {
            _secretKey = GenerateSecretKey();
        }

        public static Vault Instance
        {
            get
            {
                if (_vault == null)
                {
                    lock (_lock)
                    {
                        if (_vault == null)
                        {
                            _vault = new Vault();
                        }
                    }
                }

                return _vault;
            }
        }

        public string GetSecretKey()
        {
            return _secretKey;
        }

        private static string GenerateSecretKey()
        {
            return Guid.NewGuid().ToString("N");
        }
    }
}
