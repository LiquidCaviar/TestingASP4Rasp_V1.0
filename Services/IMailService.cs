namespace TestingASP4Rasp_V1._0.Services
{
    public interface IMailService
    {
        void SendMessage(string to, string subject, string body);
    }
}