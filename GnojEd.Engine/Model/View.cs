﻿namespace GnojEd.Engine.Model {
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;

  /// <summary>
  /// View class
  /// </summary>
  public class View : IModel {
    /// <summary>
    /// Gets or sets the Id
    /// </summary>
    public int Id {
      get;
      set;
    }

    /// <summary>
    /// Gets or sets the Name
    /// </summary>
    public string Name {
      get;
      set;
    }

    /// <summary>
    /// Gets or sets the Aka
    /// </summary>
    public string Aka {
      get;
      set;
    }

    /// <summary>
    /// Gets or sets the Url
    /// </summary>
    public string Url {
      get;
      set;
    }
  }
}
