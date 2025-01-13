using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using HotelBookingApp.Models;

namespace HotelBookingApp.Data
{
    public class BookingDatabase
    {
        readonly SQLiteAsyncConnection _database;

        
        public BookingDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
        }

        
        public async Task InitializeDatabaseAsync()
        {
            try
            {
                
                await _database.CreateTableAsync<Booking>();
                await _database.CreateTableAsync<Room>();
                await _database.CreateTableAsync<User>();
                await _database.CreateTableAsync<Payment>();
                await _database.CreateTableAsync<Review>();
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"Error creating tables: {ex.Message}");
            }
        }

        
        public Task<List<Booking>> GetBookingListsAsync() => _database.Table<Booking>().ToListAsync();
        public Task<Booking> GetBookingListAsync(int id) => _database.Table<Booking>().Where(i => i.Id == id).FirstOrDefaultAsync();
        public Task<int> SaveBookingAsync(Booking booking)
        {
            if (booking.Id != 0)
            {
                return _database.UpdateAsync(booking);
            }
            else
            {
                return _database.InsertAsync(booking);
            }
        }
        public Task<int> DeleteBookingListAsync(Booking booking) => _database.DeleteAsync(booking);

      
        public Task<List<Room>> GetRoomListsAsync() => _database.Table<Room>().ToListAsync();
        public Task<Room> GetRoomListAsync(int id) => _database.Table<Room>().Where(i => i.Id == id).FirstOrDefaultAsync();
        public Task<int> SaveRoomAsync(Room room)
        {
            if (room.Id != 0)
            {
                return _database.UpdateAsync(room);
            }
            else
            {
                return _database.InsertAsync(room);
            }
        }
        public Task<int> DeleteRoomListAsync(Room room) => _database.DeleteAsync(room);

       
        public Task<List<User>> GetUserListsAsync() => _database.Table<User>().ToListAsync();
        public Task<User> GetUserListAsync(int id) => _database.Table<User>().Where(i => i.Id == id).FirstOrDefaultAsync();
        public Task<int> SaveUserAsync(User user)
        {
            if (user.Id != 0)
            {
                return _database.UpdateAsync(user);
            }
            else
            {
                return _database.InsertAsync(user);
            }
        }
        public Task<int> DeleteUserListAsync(User user) => _database.DeleteAsync(user);

        
        public Task<List<Payment>> GetPaymentListsAsync() => _database.Table<Payment>().ToListAsync();
        public Task<Payment> GetPaymentListAsync(int id) => _database.Table<Payment>().Where(i => i.Id == id).FirstOrDefaultAsync();
        public Task<int> SavePaymentAsync(Payment payment)
        {
            if (payment.Id != 0)
            {
                return _database.UpdateAsync(payment);
            }
            else
            {
                return _database.InsertAsync(payment);
            }
        }
        public Task<int> DeletePaymentListAsync(Payment payment) => _database.DeleteAsync(payment);

       
        public Task<List<Review>> GetReviewListsAsync() => _database.Table<Review>().ToListAsync();
        public Task<Review> GetReviewListAsync(int id) => _database.Table<Review>().Where(i => i.Id == id).FirstOrDefaultAsync();
        public Task<int> SaveReviewAsync(Review review)
        {
            if (review.Id != 0)
            {
                return _database.UpdateAsync(review);
            }
            else
            {
                return _database.InsertAsync(review);
            }
        }
        public Task<int> DeleteReviewListAsync(Review review) => _database.DeleteAsync(review);
    }
}
