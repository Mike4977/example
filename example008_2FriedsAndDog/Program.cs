int distance = 10000,
    FirstFriendSpeed = 1,
    SecondFriendSpeed = 2,
    DogSpeed = 5,
    time = 0,
    count = 0;
    
int friend = 2;

while (distance > 10)
{
    if(friend == 1)
    {
        time = distance / (FirstFriendSpeed + DogSpeed);
        friend = 2;
    }
    if(friend == 2)
    {
        time = distance / (SecondFriendSpeed + DogSpeed);
        friend = 1;
    }

    distance = distance - (FirstFriendSpeed + SecondFriendSpeed) * time;
    count++;
   

}
Console.Write("Собака пробежит ");
Console.Write(count);
Console.Write(" раз.");
