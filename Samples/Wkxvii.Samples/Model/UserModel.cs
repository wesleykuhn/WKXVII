namespace Wkxvii.Samples.Model;

internal class UserModel
{
    public required string Name { get; set; }
    public required string Email { get; set; }
    public bool Active { get; set; } = true;
    public required string Picture { get; set; }

    public static IReadOnlyList<UserModel> GenMocks() => [
        new UserModel
        {
            Name = "User name 1",
            Email = "user1@example.com",
            Picture = "https://randomuser.me/api/portraits/men/69.jpg"
        },
        new UserModel
        {
            Name = "User name 2",
            Email = "user2@example.com",
            Picture = "https://randomuser.me/api/portraits/men/46.jpg",
            Active = false
        },
        new UserModel
        {
            Name = "User name 3",
            Email = "user3@example.com",
            Picture = "https://randomuser.me/api/portraits/men/64.jpg"
        },
        new UserModel
        {
            Name = "User name 4",
            Email = "user4@example.com",
            Picture = "https://randomuser.me/api/portraits/men/40.jpg",
            Active = false
        },
        new UserModel
        {
            Name = "User name 5",
            Email = "user5@example.com",
            Picture = "https://randomuser.me/api/portraits/men/1.jpg",
            Active = false
        },
        new UserModel
        {
            Name = "User name 6",
            Email = "user6@example.com",
            Picture = "https://randomuser.me/api/portraits/men/2.jpg"
        },
        new UserModel
        {
            Name = "User name 7",
            Email = "user7@example.com",
            Picture = "https://randomuser.me/api/portraits/men/3.jpg"
        },
        new UserModel
        {
            Name = "User name 8",
            Email = "user8@example.com",
            Picture = "https://randomuser.me/api/portraits/men/4.jpg",
            Active = false
        },
        new UserModel
        {
            Name = "User name 9",
            Email = "user9@example.com",
            Picture = "https://randomuser.me/api/portraits/men/5.jpg"
        },
        new UserModel
        {
            Name = "User name 10",
            Email = "user10@example.com",
            Picture = "https://randomuser.me/api/portraits/men/6.jpg"
        },
        new UserModel
        {
            Name = "User name 11",
            Email = "user11@example.com",
            Picture = "https://randomuser.me/api/portraits/men/7.jpg",
            Active = false
        },
        new UserModel
        {
            Name = "User name 12",
            Email = "user12@example.com",
            Picture = "https://randomuser.me/api/portraits/men/8.jpg"
        },
        new UserModel
        {
            Name = "User name 13",
            Email = "user13@example.com",
            Picture = "https://randomuser.me/api/portraits/men/9.jpg"
        },
        new UserModel
        {
            Name = "User name 14",
            Email = "user14@example.com",
            Picture = "https://randomuser.me/api/portraits/men/10.jpg",
            Active = false
        },
        new UserModel
        {
            Name = "User name 15",
            Email = "user15@example.com",
            Picture = "https://randomuser.me/api/portraits/men/11.jpg"
        },
        new UserModel
        {
            Name = "User name 16",
            Email = "user16@example.com",
            Picture = "https://randomuser.me/api/portraits/men/12.jpg"
        },
        new UserModel
        {
            Name = "User name 17",
            Email = "user17@example.com",
            Picture = "https://randomuser.me/api/portraits/men/13.jpg"
        },
        new UserModel
        {
            Name = "User name 18",
            Email = "user18@example.com",
            Picture = "https://randomuser.me/api/portraits/men/14.jpg"
        },
        new UserModel
        {
            Name = "User name 19",
            Email = "user19@example.com",
            Picture = "https://randomuser.me/api/portraits/men/15.jpg",
            Active = false
        },
        new UserModel
        {
            Name = "User name 20",
            Email = "user20@example.com",
            Picture = "https://randomuser.me/api/portraits/men/16.jpg"
        }
    ];
}
