using System;
using System.Threading.Tasks;

namespace OliveStudio;

public delegate Task AsyncEventHandler(object sender, EventArgs e);

public delegate Task AsyncEventHandler<in TEventArgs>(object sender, TEventArgs e) where TEventArgs : EventArgs;
