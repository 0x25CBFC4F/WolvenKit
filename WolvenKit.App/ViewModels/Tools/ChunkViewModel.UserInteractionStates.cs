using System;
using System.Collections.Generic;
using WolvenKit.RED4.Types;

// ReSharper disable once CheckNamespace
namespace WolvenKit.App.ViewModels.Shell;

public partial class ChunkViewModel
{
    // Types that should never be changed by the user 
    private static readonly List<Type> s_globalReadonlyTypes =
    [
        typeof(SerializationDeferredDataBuffer),
        typeof(rendRenderTextureBlobMemoryLayout),
        typeof(rendRenderTextureBlobPlacement),
        typeof(rendRenderTextureBlobMipMapInfo),
        typeof(rendRenderTextureBlobTextureInfo),
        typeof(rendRenderTextureBlobSizeInfo),
    ];

    // Properties (by name) that should never be changed by the user
    private static readonly List<string> s_globalReadonlyFields =
    [
        "saveDateTime", "resourceVersion", "cookingPlatform"
    ];

    // Fields (by parent class) that should be marked as read-only
    private static readonly Dictionary<Type, List<string>> s_readonlyFields = new()
    {
        { typeof(CBitmapTexture), ["width", "height"] }, // xbm
        { typeof(CMesh), ["geometryHash", "consoleBias"] }, // mesh
    };

    private void CalculateIsReadOnly()
    {
        if (s_globalReadonlyFields.Contains(Name) || s_globalReadonlyTypes.Contains(ResolvedData.GetType()))
        {
            IsReadOnly = true;
            return;
        }

        if (Parent is not null && s_readonlyFields.TryGetValue(Parent.ResolvedData.GetType(), out var hiddenFields))
        {
            IsReadOnly = hiddenFields.Contains(Name);
        }
    }

    private void CalculateUserInteractionStates()
    {
        // Either a root field, or a field that isn't initialized yet
        if (Parent is null || ResolvedData is RedDummy || IsReadOnly || IsHiddenByNoobFilter)
        {
            return;
        }

        CalculateIsReadOnly();

        // If we're in simple view, hide all "unnecessary" properties from the user
        if (_settingsManager.IsNoobFilterEnabled())
        {
            CalculateConditionalHiding();
        }
    }

    /// <summary>
    /// Should this property be hidden from the default view (because the user has toggled the noob filter)?
    /// TODO: Not implemented yet
    /// </summary>
    private void CalculateConditionalHiding()
    {
        if (IsReadOnly)
        {
            IsHiddenByNoobFilter = true;
            return;
        }

        if (Parent is not null && s_hiddenFields.TryGetValue(Parent.ResolvedData.GetType(), out var hiddenFields))
        {
            IsHiddenByNoobFilter = hiddenFields.Contains(Name);
        }
    }

    private static readonly Dictionary<Type, List<string>> s_hiddenFields = new()
    {
        {
            typeof(CMesh), [
                "boundingBox", "boneNames", "boneRigMatrices", "castGlobalShadowsCachedInCook", "castLocalShadowsCachedInCook",
                "castRayTracedShadowsFromOriginalGeometry", "consoleBias", "floatTrackNames", "forceLoadAllAppearances", "lodBoneMask",
                "objectType", "resourceVersion", "saveDateTime", "surfaceAreaPerAxis", "useRayTracingShadowLODBias"
            ]
        },
    };
}