using System;

class UserService
{
    public bool PayMyDebts(string userID)
    {
        var success = false;

        // El usuario necesita saber si tiene dinero en el banco para cubrir su deuda del mes
        if (HasMoneyAtBank(userID))
        {
            // El usuario va a pagar sus deudas para el mes actual
            success = true;
        }

        return success;
    }

    public bool HasMoneyAtBank(string userId)
    {
        return true;
    }
}

