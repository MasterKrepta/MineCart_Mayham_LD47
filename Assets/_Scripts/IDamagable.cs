﻿public interface IDamagable
{
    float MaxHealth { get; set; }
    float CurrentHealth { get; set; }
    void TakeDamage(float amount);
}
