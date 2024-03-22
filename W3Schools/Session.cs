using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W3Schools.Model;

namespace W3Schools
{
    internal class Session
    {
        public User CurrentUser { get; set; }
        public int SessionId { get; set; }
        public DateTime StartedAt { get; set; }
        public TimeSpan TimeOut { get; set; } = TimeSpan.FromHours(1); // todo : add a LastOperationDate feature
        public bool IsLoggedIn => CurrentUser != null;
        public bool IsExpired => StartedAt.Add(TimeOut) < DateTime.Now;
        public bool IsValid => IsLoggedIn && !IsExpired;

        private static Session instance;

        public event EventHandler OnCreated;
        public event EventHandler OnInvalidated;
        private Session() { }

        public static Session GetInstance()
        {
            if (instance == null)
            {
                instance = new Session();
            }
            return instance;
        }
        public void Invalidate()
        {
            CurrentUser = null;
            SessionId = 0;
            StartedAt = DateTime.MinValue;
            OnInvalidated?.Invoke(this, EventArgs.Empty);
        }

        Random rand = new();
        public void Create(User user)
        {
            CurrentUser = user;
            SessionId = rand.Next(minValue: 1, maxValue: int.MaxValue);
            StartedAt = DateTime.Now;
            // Fire Event ==> CREATED
            OnCreated?.Invoke(this, EventArgs.Empty);
        }

    }
}
