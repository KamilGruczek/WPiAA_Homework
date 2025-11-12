using SingletonVault;

var _value1 = Vault.Instance.GetSecretKey();
var _value2 = Vault.Instance.GetSecretKey();

Console.WriteLine($"Secret Key 1: {_value1}");
Console.WriteLine($"Secret Key 2: {_value2}");
Console.WriteLine($"Are both keys equal? {_value1 == _value2}");
