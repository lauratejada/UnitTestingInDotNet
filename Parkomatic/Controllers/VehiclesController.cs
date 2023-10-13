using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Parkomatic.Data;
using Parkomatic.Models;
using Parkomatic.Models.BusinessLogicLayer;

namespace Parkomatic.Controllers
{
    public class VehiclesController : Controller
    {
        VehicleBusinessLogic vbl;
        public VehiclesController(IRepository<Vehicle> vehicleRepo, IRepository<Pass> passRepo)
        {
            vbl = new VehicleBusinessLogic(vehicleRepo, passRepo);
        }

        // GET: Vehicles
        public async Task<IActionResult> Index()
        {
            //var parkomaticContext = _context.Vehicles.Include(v => v.Pass);
            return View(vbl.GetAllVehicles());
        }

        // GET: Vehicles/Details/5
        public async Task<IActionResult> Details(int id)
        {

            if (id == null || vbl.GetVehicle(id) == null)
            {
                return NotFound();
            }

            //var vehicle = await _context.Vehicles
               // .Include(v => v.Pass)
               // .FirstOrDefaultAsync(m => m.ID == id);
            if (vbl.GetVehicle(id) == null)
            {
                return NotFound();
            }

            return View(vbl.GetVehicle(id));
        }

        // GET: Vehicles/Create
        public IActionResult Create()
        {
            ViewData["PassID"] = new SelectList(vbl.GetAllPasses(), "ID", "ID");
            return View();
        }

        // POST: Vehicles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,PassID,Parked")] Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                //_context.Add(vehicle);
                //await _context.SaveChangesAsync();
                vbl.AddVehicle(vehicle);
                return RedirectToAction(nameof(Index));
            }
            ViewData["PassID"] = new SelectList(vbl.GetAllPasses(), "ID", "ID", vehicle.PassID);
            return View(vehicle);
        }

        // GET: Vehicles/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            if (id == null || vbl.GetAllVehicles() == null)
            {
                return NotFound();
            }

            var vehicle = vbl.GetVehicle(id); //await _context.Vehicles.FindAsync(id);
            if (vehicle == null)
            {
                return NotFound();
            }
            ViewData["PassID"] = new SelectList(vbl.GetAllPasses(), "ID", "ID", vehicle.PassID);
            return View(vehicle);
        }

        // POST: Vehicles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,PassID,Parked")] Vehicle vehicle)
        {
            if (id != vehicle.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    vbl.UpdateVehicle(vehicle);
                   // await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VehicleExists(vehicle.ID))
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
            ViewData["PassID"] = new SelectList(vbl.GetAllPasses(), "ID", "ID", vehicle.PassID);
            return View(vehicle);
        }

        // GET: Vehicles/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null || vbl.GetAllVehicles() == null)
            {
                return NotFound();
            }

            var vehicle = vbl.GetVehicle(id);//await _context.Vehicles
                //.Include(v => v.Pass)
                //.FirstOrDefaultAsync(m => m.ID == id);
            if (vehicle == null)
            {
                return NotFound();
            }

            return View(vehicle);
        }

        // POST: Vehicles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (vbl.GetAllVehicles() == null)
            {
                return Problem("Entity set 'ParkomaticContext.Vehicle'  is null.");
            }
            var vehicle = vbl.GetVehicle(id);//await _context.Vehicles.FindAsync(id);
            if (vehicle != null)
            {
                // _context.Vehicles.Remove(vehicle);
                vbl.RemoveVehicle(vehicle);
            }

           // await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VehicleExists(int id)
        {
            return (vbl.GetVehicle(id) != null);//_context.Vehicles?.Any(e => e.ID == id)).GetValueOrDefault();
        }
        
    }
}
