
interface Move<T>
{
    T moveLeft();
    T moveRight();
    T moveUp();
    T moveDown();
}

class Tank
{
    public string name;
    public int x = 0;
    public int y = 0;
}

class Start : Move<Tank>
{
    public void moveLeft()
    {
        x--;
    }
    public void moveRight()
    {
        x++;
    }
    public void moveUp()
    {
        y++;
    }
    public void moveDown()
    {
        y--;
    }
}