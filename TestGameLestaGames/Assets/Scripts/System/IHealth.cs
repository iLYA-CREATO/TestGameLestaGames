internal interface IHealth
{
    /// <summary>
    /// Метод получения урона
    /// </summary>
    public void Damage(int damage);

    public void Regen(int regen);

    public void Death();
}