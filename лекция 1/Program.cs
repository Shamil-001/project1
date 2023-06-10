int count = 0; 
int distance = 8000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int friend = 2;

while (distance > 10)
{
    if (friend == 1)
    {
        int time = distance / (firstFriendSpeed + dogSpeed);
        distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
        friend = 2;
    }
    else
    {
        int time = distance / (secondFriendSpeed + dogSpeed);
        distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
        friend = 1;
    }
    count++;
}
Console.Write("Собака бежит ");
Console.Write(count);
Console.Write(" раз");