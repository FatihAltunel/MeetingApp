namespace MeetingApp.Models
{
    public static class Repository{
        static Repository(){
            _users.Add(new UserInfo(){
                Id=1,
                Name = "Cailin Stafford",
                Phone = "1-729-542-2429",
		        Email = "scelerisque.mollis@hotmail.ca",
                ParticipateStatus=true
            });
            _users.Add(new UserInfo(){
                Id=2,
                Name = "Chester Davidson",
                Phone = "(574) 301-8851",
		        Email = "parturient.montes.nascetur@google.edu",
                ParticipateStatus=false
            });
            _users.Add(new UserInfo(){
                Id=3,
                Name = "Larissa Jimenez",
                Phone = "(722) 441-6455",
		        Email = "molestie.pharetra@aol.net",
                ParticipateStatus=true
            });
        }
        private static List<UserInfo> _users = new();

        public static List<UserInfo> Users{
            get{
                return _users;
            }
        }
        public static void AddUser(UserInfo user){
            user.Id = Users.Count()+1;
            _users.Add(user);
        }
    }
}