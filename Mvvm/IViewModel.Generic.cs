﻿namespace BellaCode.Mvvm
{
    /// <summary>
    /// A strong typed mediator between a view and a model.
    /// </summary>
    /// <typeparam name="TView">The type of the view.</typeparam>
    /// <typeparam name="TModel">The type of the model.</typeparam>
    public interface IViewModel<TView, TModel> : IViewModel where TView : class where TModel : class
    {
        /// <summary>
        /// Gets or sets the view.
        /// </summary>
        /// <remarks>
        /// In the M-V-VM pattern, the view model should have no dependencies on the view.
        /// However, the view model may need to provide the view when raising events or calling other services.
        /// As well some situations interacting with the UI (through an interface) is required for performance reasons or existing control limitations.        
        /// </remarks>
        new TView View { get; set; }

        /// <summary>
        /// Gets or sets the model.
        /// </summary> 
        new TModel Model { get; set; }
    }
}
