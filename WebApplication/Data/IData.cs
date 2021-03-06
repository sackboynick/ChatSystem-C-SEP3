using System.Collections.Generic;
using System.Threading.Tasks;
using Entities;

namespace WebApplication.Data
{
    public interface IData
    {
        public Task<Task> SendMessage(Message message);
        public Task<PrivateChat> GetPrivateChat(int chatId);
        public Task<GroupChat> GetGroupChat(int chatId);       
        public Task<Task> AddParticipantToGroup(Participant participant);
        public Task<Task> RemoveParticipantFromGroup(int participantId);
        public Task<Task> PromoteParticipantToAdmin(Participant participant);
        public Task<Task> CreateGroup(GroupChat groupChat);
        
        public Task<User> GetUserFromUsername(string username);
        public Task<Task> AddFriendship(Friendship friendship);
        public Task<Task> RemoveFriend(int friendshipId);
        public Task<Task> UpdateFriendship(Friendship friendship);
        public Task<Task> UpdateMessage(Message message);
        public Task<Message> GetMessage(int messageId);

        public Task<Participant> GetParticipant(int participantId);

        public Task<Task> UpdateUser(User user);

        Task<List<Friendship>> GetAllFriendsOfUser(int userId);
        Task<List<PrivateChat>> GetAllUserPrivateChats(int userId);
        Task<List<GroupChat>> GetAllUserGroupChats(int userId);
        Task<List<Message>> GetAllChatMessages(int chatId);
        Task<List<Message>> GetAllGroupMessages(int groupId);
        Task<List<Participant>> GetAllGroupParticipants(int groupId);
        Task<List<Chat>> GetAllUserChats(int userId);

        Task<Task> RemoveMessage(int messageId);
        Task<Friendship> GetFriendship(int friendshipId);
        Task<List<User>> GetAllUsers();
        Task<List<GroupChat>> GetGroupChats();
        Task<User> GetUser(int userId);
        Task<Task> AddPrivateChat(PrivateChat privateChat);
        Task<List<PrivateChat>> GetPrivateChats();
    }
}