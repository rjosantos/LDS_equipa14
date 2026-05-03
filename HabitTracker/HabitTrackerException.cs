using System;

namespace HabitTracker
{
	class HabitTrackerException : Exception
	{
		public HabitTrackerException(string mensagem, Exception inner)
			: base(mensagem, inner) { }
	}
}