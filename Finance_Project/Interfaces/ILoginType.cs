using Finance_Project.Reposotory;


namespace Finance_Project.DataAccessLayer
{
    public interface ILoginType
    {
         public int Update(Logintype password);
        public void Delete(Logintype userid);
    }
}
