using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GwentApi.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                if (!context.Cards.Any())
                {
                    context.Cards.AddRange(
                        new Card
                        {
                            Name = "Geralt: Igni",
                            Categories = "Witcher",
                            PrimaryCategory = "Witcher",
                            Color = "Gold",
                            Description = "Deploy (Melee): Destroy the highest unit(s) on an enemy row with a total of 20 or more power.",
                            Faction = "Neutral",
                            Power = 2,
                            Provision = 11,
                            Rarity = "Legendary",
                            Type = "Unit",
                            ArtUrl = "geraltigni.jpg"
                        },
                        new Card
                        {
                            Name = "Geralt: Aard",
                            Categories = "Witcher",
                            PrimaryCategory = "Witcher",
                            Color = "Gold",
                            Description = "Deploy (Melee): Damage 3 enemy units by 2, then move them to the ranged row.",
                            Faction = "Neutral",
                            Power = 3,
                            Provision = 11,
                            Rarity = "Legendary",
                            Type = "Unit",
                            ArtUrl = "geraltaard.jpg"
                        },
                        new Card
                        {
                            Name = "Geralt: Professional",
                            Categories = "Witcher",
                            PrimaryCategory = "Witcher",
                            Color = "Gold",
                            Description = "Deploy (Melee): Damage an enemy unit by 3. If its power was a multiple of 3, destroy it instead.",
                            Faction = "Neutral",
                            Power = 3,
                            Provision = 11,
                            Rarity = "Legendary",
                            Type = "Unit",
                            ArtUrl = "geraltprofessional.jpg"
                        },
                        new Card
                        {
                            Name = "Geralt: Yrden",
                            Categories = "Witcher",
                            PrimaryCategory = "Witcher",
                            Color = "Gold",
                            Description = "Deploy: Restore all units on a row to their base power.",
                            Faction = "Neutral",
                            Power = 2,
                            Provision = 11,
                            Rarity = "Legendary",
                            Type = "Unit",
                            ArtUrl = "geraltyrden.jpg"
                        },
                        new Card
                        {
                            Name = "Geralt of Rivia",
                            Categories = "Witcher",
                            PrimaryCategory = "Witcher",
                            Color = "Gold",
                            Description = "Deploy: Destroy an enemy unit with 8 or more power.",
                            Faction = "Neutral",
                            Power = 3,
                            Provision = 10,
                            Rarity = "Legendary",
                            Type = "Unit",
                            ArtUrl = "geraltofrivia.jpg"
                        },
                        new Card
                        {
                            Name = "Crimson Curse",
                            Color = "Gold",
                            Description = "Destroy an allied unit, then apply a Blood Moon row effect to both allied rows and set its duration equal to the destroyed unit's power. Blood Moon: Every allied turn, on turn start, boost a random Vampire on this row by 2.",
                            Faction = "Monsters",
                            Provision = 11,
                            Rarity = "Legendary",
                            Type = "Special",
                            ArtUrl = "crimsoncurse.jpg"
                        },
                        new Card
                        {
                            Name = "Anna Henrietta",
                            Color = "Leader",
                            Description = "Order: Create and play a card from your opponent's hand.",
                            Faction = "Nilfgaard",
                            Provision = 15,
                            Rarity = "Legendary",
                            Type = "Leader",
                            ArtUrl = "annahenrietta.jpg"
                        },
                        new Card
                        {
                            Name = "Serpent Trap",
                            Categories = "Trap",
                            PrimaryCategory = "Trap",
                            Color = "Gold",
                            Description = "Ambush: Destroy the next special card played by your opponent before it triggers any abilities.",
                            Faction = "Scoia'tael",
                            Provision = 6,
                            Rarity = "Epic",
                            Type = "Artifact",
                            ArtUrl = "serpenttrap.jpg"
                        },
                        new Card
                        {
                            Name = "Blue Stripes Commando",
                            Categories = "Human, Soldier",
                            PrimaryCategory = "Human",
                            Color = "Bronze",
                            Description = "Order: Summon all copies of this unit from your deck to this row.",
                            Faction = "Northern Realms",
                            Power = 4,
                            Provision = 6,
                            Rarity = "Rare",
                            Type = "Unit",
                            ArtUrl = "bluestripescommando.jpg"
                        });
                    context.SaveChanges();
                }
            }
                
        }
    }
}
