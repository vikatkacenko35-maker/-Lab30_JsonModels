using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;
using HeroesApi.Data;
using HeroesApi.Models;
using Microsoft.VisualBasic;

namespace HeroesApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HeroesController : ControllerBase {
    [HttpGet]
    public ActionResult<List<Hero>> GetAll() {
        return Ok(HeroesStore.Heroes);
    }
    [HttpGet("{id}")]
    public ActionResult<Hero> GetById(int id) {
        var hero = HeroesStore.Heroes.FirstOrDefault(h => h.Id == id);
        if (hero is null) {
            return NotFound(new { Message = $"Такой герой не найден" });
        }
        return Ok(hero);
    }
    [HttpGet("demo")]
    public ActionResult GetDemo() {
        var hero = HeroesStore.Heroes.First();
        var defaultOptions = new JsonSerializerOptions {
            WriteIndented = true
        };
        var ourOptions = new JsonSerializerOptions {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true,
            Converters = { new JsonStringEnumConverter() }
        };
        return Ok(new {
            withDefaltSettings = JsonSerializer.Deserialize<object>(
JsonSerializer.Serialize(hero, defaultOptions), defaultOptions),
            withOurSettings = JsonSerializer.Deserialize<object>(
JsonSerializer.Serialize(hero, ourOptions), ourOptions),
            note = "Сравните имена полей и значений в двух разных вариантах"

        });
        }
    
}