namespace trybank;

public class Trybank
    //0 -> Número da conta
    //1 -> Agência
    //2 -> Senha
    //3 -> Saldo
{
    public bool Logged;
    public int loggedUser;
    public int[,] Bank;
    public int registeredAccounts;
    private int maxAccounts = 50;
    public Trybank()
    {
        loggedUser = -99;
        registeredAccounts = 0;
        Logged = false;
        Bank = new int[maxAccounts, 4];
    }

    // 1. Construa a funcionalidade de cadastrar novas contas
    public void RegisterAccount(int number, int agency, int pass)
    {

            for(int count = 0; count < maxAccounts; count += 1)
            {
                if(number == Bank[count, 0] && agency == Bank[count, 1]) {
                    throw new ArgumentException("A conta já está sendo usada!");
                }
            }

            
            if(registeredAccounts >= maxAccounts) {
                throw new ArgumentException("Já atingimos o máximo de contas");
            }
            
            Bank[registeredAccounts, 0] = number;
            Bank[registeredAccounts, 1] = agency;
            Bank[registeredAccounts, 2] = pass;
            Bank[registeredAccounts, 3] = 0;

            registeredAccounts += 1;
    } 
    

    // 2. Construa a funcionalidade de fazer Login
    public void Login(int number, int agency, int pass)
    {
        if(loggedUser >= 0) 
        {
            throw new AccessViolationException("Usuário já está logado");
        }

        for(int count = 0; count < maxAccounts; count += 1)
        {
         if(number == Bank[count, 0] && agency == Bank[count, 1])
         {
            if(pass == Bank[count, 2])
            {
                Logged = true;
                loggedUser+= 1;
            }
            else 
            {
                throw new ArgumentException("Senha incorreta");
            }
         }   

        }
    }

    // 3. Construa a funcionalidade de fazer Logout
    public void Logout()
    {
        throw new NotImplementedException();
    }

    // 4. Construa a funcionalidade de checar o saldo
    public int CheckBalance()
    {
        throw new NotImplementedException();   
    }

    // 5. Construa a funcionalidade de depositar dinheiro
    public void Deposit(int value)
    {
        throw new NotImplementedException();
    }

    // 6. Construa a funcionalidade de sacar dinheiro
    public void Withdraw(int value)
    {
        throw new NotImplementedException();
    }

    // 7. Construa a funcionalidade de transferir dinheiro entre contas
    public void Transfer(int destinationNumber, int destinationAgency, int value)
    {
        throw new NotImplementedException();
        // comentario test
    }

   
}
