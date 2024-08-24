using System;
using System.Threading.Tasks;

namespace Utility;

public delegate Task AsyncEventHandler(object sender, EventArgs e);
