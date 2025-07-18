﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Soccer.Models;


namespace Soccer.Controllers
{
    public class PlayersController : Controller
    {
        private readonly SoccerContext _context;

        public PlayersController(SoccerContext context)
        {
            _context = context;
        }

        // GET: Players
        public IActionResult Index(int? team, string? position)
        {
            // Load all players including related team data (including Teams)
            IQueryable<Players> players = _context.Players.Include(p => p.Team);

            // Filter by team if the parameter is provided and not equal to 0
            if (team != null && team != 0)
            {
                players = players.Where(p => p.TeamId == team);
            }

            // Filter by position if the string is provided
            if (!string.IsNullOrEmpty(position))
            {
                players = players.Where(p => p.Position==position);
            }

            // Get the list of all teams for the dropdown list
            List<Teams> teams = _context.Teams.ToList();

            // Add "All" option at the beginning of the list so the user can select all
            teams.Insert(0, new Teams { Name = "All", Id = 0 });

            // Create the ViewModel and pass it to the view:
            // - filtered list of players
            // - list of teams as SelectList (for the dropdown)
            // - the current position (if a filter is applied)
            UserListViewModel viewModel = new UserListViewModel
            {
                Players = players.ToList(),
                Teams = new SelectList(teams, "Id", "Name", team),
                Position = position
            };

            // Return the view with the model
            return View(viewModel);
        }

        // GET: Players/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Players == null)
            {
                return NotFound();
            }

            var players = await _context.Players
                .Include(p => p.Team)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (players == null)
            {
                return NotFound();
            }

            return View(players);
        }

        // GET: Players/Create
        public IActionResult Create()
        {
            ViewData["TeamId"] = new SelectList(_context.Teams, "Id", "Name");
            return View();
        }

        // POST: Players/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Age,Position,TeamId")] Players players)
        {
            _context.Add(players);
             await _context.SaveChangesAsync();
             return RedirectToAction(nameof(Index));
        }

        // GET: Players/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Players == null)
            {
                return NotFound();
            }

            var players = await _context.Players.FindAsync(id);
            if (players == null)
            {
                return NotFound();
            }
            ViewData["TeamId"] = new SelectList(_context.Teams, "Id", "Name", players.TeamId);
            return View(players);
        }

        // POST: Players/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Age,Position,TeamId")] Players players)
        {
            if (id != players.Id)
            {
                return NotFound();
            }

            try
            {
                _context.Update(players);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlayersExists(players.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));

        }

        // GET: Players/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Players == null)
            {
                return NotFound();
            }

            var players = await _context.Players
                .Include(p => p.Team)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (players == null)
            {
                return NotFound();
            }

            return View(players);
        }

        // POST: Players/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Players == null)
            {
                return Problem("Entity set 'SoccerContext.Players'  is null.");
            }
            var players = await _context.Players.FindAsync(id);
            if (players != null)
            {
                _context.Players.Remove(players);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlayersExists(int id)
        {
          return (_context.Players?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
