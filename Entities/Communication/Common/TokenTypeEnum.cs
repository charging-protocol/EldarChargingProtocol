namespace Entities.Communication.Common
{
    public enum TokenTypeEnum : byte
    {
        None,
        Code,
        RFID,
        eMAID,// Electro-mobility account id 
        Swipe,
        EMV,
        Contactless,
        ServerToken
    }
}
