//
// Copyright Fela Ameghino 2015-2023
//
// Distributed under the GNU General Public License v3.0. (See accompanying
// file LICENSE or copy at https://www.gnu.org/licenses/gpl-3.0.txt)
//
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//       LottieGen version:
//           7.1.2-build.15+g2b49bb9edc
//       
//       Command:
//           LottieGen -GenerateColorBindings -Language CSharp -MinimumUapVersion 8 -Namespace Unigram.Assets.Icons -Public -WinUIVersion 2.7 -InputFile GifToEmoji.json
//       
//       Input file:
//           GifToEmoji.json (8933 bytes created 15:57+02:00 Jul 25 2022)
//       
//       LottieGen source:
//           http://aka.ms/Lottie
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// ___________________________________________________________
// |       Object stats       | UAP v11 count | UAP v7 count |
// |__________________________|_______________|______________|
// | All CompositionObjects   |            71 |           67 |
// |--------------------------+---------------+--------------|
// | Expression animators     |             9 |            8 |
// | KeyFrame animators       |             6 |            5 |
// | Reference parameters     |            11 |           10 |
// | Expression operations    |            12 |           12 |
// |--------------------------+---------------+--------------|
// | Animated brushes         |             3 |            3 |
// | Animated gradient stops  |             - |            - |
// | ExpressionAnimations     |             4 |            4 |
// | PathKeyFrameAnimations   |             1 |            - |
// |--------------------------+---------------+--------------|
// | ContainerVisuals         |             1 |            1 |
// | ShapeVisuals             |             1 |            1 |
// |--------------------------+---------------+--------------|
// | ContainerShapes          |             2 |            2 |
// | CompositionSpriteShapes  |             5 |            5 |
// |--------------------------+---------------+--------------|
// | Brushes                  |             3 |            3 |
// | Gradient stops           |             - |            - |
// | CompositionVisualSurface |             - |            - |
// -----------------------------------------------------------
using Microsoft.Graphics.Canvas.Geometry;
using System;
using System.Collections.Generic;
using System.Numerics;
using Windows.Graphics;
using Windows.UI;
using Windows.UI.Composition;

namespace Unigram.Assets.Icons
{
    // Name:        gif_to_emoji
    // Frame rate:  60 fps
    // Frame count: 20
    // Duration:    333.3 mS
    // ___________________________________________________________
    // | Theme property |   Accessor   | Type  |  Default value  |
    // |________________|______________|_______|_________________|
    // | #000000        | Color_000000 | Color | #FF000000 Black |
    // -----------------------------------------------------------
    public sealed class GifToEmoji
        : Microsoft.UI.Xaml.Controls.IAnimatedVisualSource
        , Microsoft.UI.Xaml.Controls.IAnimatedVisualSource2
    {
        // Animation duration: 0.333 seconds.
        internal const long c_durationTicks = 3333333;

        // Theme property: Color_000000.
        internal static readonly Color c_themeColor_000000 = Color.FromArgb(0xFF, 0x00, 0x00, 0x00);

        CompositionPropertySet _themeProperties;
        Color _themeColor_000000 = c_themeColor_000000;

        // Theme properties.
        public Color Color_000000
        {
            get => _themeColor_000000;
            set
            {
                _themeColor_000000 = value;
                if (_themeProperties != null)
                {
                    _themeProperties.InsertVector4("Color_000000", ColorAsVector4((Color)_themeColor_000000));
                }
            }
        }

        static Vector4 ColorAsVector4(Color color) => new Vector4(color.R, color.G, color.B, color.A);

        CompositionPropertySet EnsureThemeProperties(Compositor compositor)
        {
            if (_themeProperties == null)
            {
                _themeProperties = compositor.CreatePropertySet();
                _themeProperties.InsertVector4("Color_000000", ColorAsVector4((Color)Color_000000));
            }
            return _themeProperties;
        }

        public Microsoft.UI.Xaml.Controls.IAnimatedVisual TryCreateAnimatedVisual(Compositor compositor)
        {
            object ignored = null;
            return TryCreateAnimatedVisual(compositor, out ignored);
        }

        public Microsoft.UI.Xaml.Controls.IAnimatedVisual TryCreateAnimatedVisual(Compositor compositor, out object diagnostics)
        {
            diagnostics = null;
            EnsureThemeProperties(compositor);

            if (GifToEmoji_AnimatedVisual_UAPv11.IsRuntimeCompatible())
            {
                var res = 
                    new GifToEmoji_AnimatedVisual_UAPv11(
                        compositor,
                        _themeProperties
                        );
                    res.CreateAnimations();
                    return res;
            }

            return null;
        }

        /// <summary>
        /// Gets the number of frames in the animation.
        /// </summary>
        public double FrameCount => 20d;

        /// <summary>
        /// Gets the frame rate of the animation.
        /// </summary>
        public double Framerate => 60d;

        /// <summary>
        /// Gets the duration of the animation.
        /// </summary>
        public TimeSpan Duration => TimeSpan.FromTicks(c_durationTicks);

        /// <summary>
        /// Converts a zero-based frame number to the corresponding progress value denoting the
        /// start of the frame.
        /// </summary>
        public double FrameToProgress(double frameNumber)
        {
            return frameNumber / 20d;
        }

        /// <summary>
        /// Returns a map from marker names to corresponding progress values.
        /// </summary>
        public IReadOnlyDictionary<string, double> Markers =>
            new Dictionary<string, double>
            {
            };

        /// <summary>
        /// Sets the color property with the given name, or does nothing if no such property
        /// exists.
        /// </summary>
        public void SetColorProperty(string propertyName, Color value)
        {
            if (propertyName == "Color_000000")
            {
                _themeColor_000000 = value;
            }
            else
            {
                return;
            }

            if (_themeProperties != null)
            {
                _themeProperties.InsertVector4(propertyName, ColorAsVector4(value));
            }
        }

        /// <summary>
        /// Sets the scalar property with the given name, or does nothing if no such property
        /// exists.
        /// </summary>
        public void SetScalarProperty(string propertyName, double value)
        {
        }

        sealed class GifToEmoji_AnimatedVisual_UAPv11 : Microsoft.UI.Xaml.Controls.IAnimatedVisual
        {
            const long c_durationTicks = 3333333;
            readonly Compositor _c;
            readonly ExpressionAnimation _reusableExpressionAnimation;
            readonly CompositionPropertySet _themeProperties;
            CompositionColorBrush _themeColor_Color_000000_0;
            CompositionColorBrush _themeColor_Color_000000_1;
            CompositionColorBrush _themeColor_Color_000000_2;
            CompositionContainerShape _containerShape_0;
            CompositionContainerShape _containerShape_1;
            CompositionPathGeometry _pathGeometry_0;
            CompositionPathGeometry _pathGeometry_3;
            ContainerVisual _root;
            CubicBezierEasingFunction _cubicBezierEasingFunction_0;
            ExpressionAnimation _rootProgress;
            StepEasingFunction _holdThenStepEasingFunction;

            static void StartProgressBoundAnimation(
                CompositionObject target,
                string animatedPropertyName,
                CompositionAnimation animation,
                ExpressionAnimation controllerProgressExpression)
            {
                target.StartAnimation(animatedPropertyName, animation);
                var controller = target.TryGetAnimationController(animatedPropertyName);
                controller.Pause();
                controller.StartAnimation("Progress", controllerProgressExpression);
            }

            void BindProperty(
                CompositionObject target,
                string animatedPropertyName,
                string expression,
                string referenceParameterName,
                CompositionObject referencedObject)
            {
                _reusableExpressionAnimation.ClearAllParameters();
                _reusableExpressionAnimation.Expression = expression;
                _reusableExpressionAnimation.SetReferenceParameter(referenceParameterName, referencedObject);
                target.StartAnimation(animatedPropertyName, _reusableExpressionAnimation);
            }

            void BindProperty2(
                CompositionObject target,
                string animatedPropertyName,
                string expression,
                string referenceParameterName0,
                CompositionObject referencedObject0,
                string referenceParameterName1,
                CompositionObject referencedObject1)
            {
                _reusableExpressionAnimation.ClearAllParameters();
                _reusableExpressionAnimation.Expression = expression;
                _reusableExpressionAnimation.SetReferenceParameter(referenceParameterName0, referencedObject0);
                _reusableExpressionAnimation.SetReferenceParameter(referenceParameterName1, referencedObject1);
                target.StartAnimation(animatedPropertyName, _reusableExpressionAnimation);
            }

            PathKeyFrameAnimation CreatePathKeyFrameAnimation(float initialProgress, CompositionPath initialValue, CompositionEasingFunction initialEasingFunction)
            {
                var result = _c.CreatePathKeyFrameAnimation();
                result.Duration = TimeSpan.FromTicks(c_durationTicks);
                result.InsertKeyFrame(initialProgress, initialValue, initialEasingFunction);
                return result;
            }

            ScalarKeyFrameAnimation CreateScalarKeyFrameAnimation(float initialProgress, float initialValue, CompositionEasingFunction initialEasingFunction)
            {
                var result = _c.CreateScalarKeyFrameAnimation();
                result.Duration = TimeSpan.FromTicks(c_durationTicks);
                result.InsertKeyFrame(initialProgress, initialValue, initialEasingFunction);
                return result;
            }

            Vector2KeyFrameAnimation CreateVector2KeyFrameAnimation(float initialProgress, Vector2 initialValue, CompositionEasingFunction initialEasingFunction)
            {
                var result = _c.CreateVector2KeyFrameAnimation();
                result.Duration = TimeSpan.FromTicks(c_durationTicks);
                result.InsertKeyFrame(initialProgress, initialValue, initialEasingFunction);
                return result;
            }

            CompositionSpriteShape CreateSpriteShape(CompositionGeometry geometry, Matrix3x2 transformMatrix)
            {
                var result = _c.CreateSpriteShape(geometry);
                result.TransformMatrix = transformMatrix;
                return result;
            }

            CompositionSpriteShape CreateSpriteShape(CompositionGeometry geometry, Matrix3x2 transformMatrix, CompositionBrush fillBrush)
            {
                var result = _c.CreateSpriteShape(geometry);
                result.TransformMatrix = transformMatrix;
                result.FillBrush = fillBrush;
                return result;
            }

            // - - - - Layer aggregator
            // - - -  Offset:<120, 120>
            // - Path
            CanvasGeometry Geometry_0()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.BeginFigure(new Vector2(-5.37900019F, -8F));
                    builder.AddCubicBezier(new Vector2(-7.65500021F, -8F), new Vector2(-9.5F, -6.15500021F), new Vector2(-9.5F, -3.87899995F));
                    builder.AddCubicBezier(new Vector2(-9.5F, -3.87899995F), new Vector2(-9.5F, 3.87899995F), new Vector2(-9.5F, 3.87899995F));
                    builder.AddCubicBezier(new Vector2(-9.5F, 6.15500021F), new Vector2(-7.65500021F, 8F), new Vector2(-5.37900019F, 8F));
                    builder.AddCubicBezier(new Vector2(-5.37900019F, 8F), new Vector2(5.37900019F, 8F), new Vector2(5.37900019F, 8F));
                    builder.AddCubicBezier(new Vector2(7.65500021F, 8F), new Vector2(9.5F, 6.15500021F), new Vector2(9.5F, 3.87899995F));
                    builder.AddCubicBezier(new Vector2(9.5F, 3.87899995F), new Vector2(9.5F, -3.87899995F), new Vector2(9.5F, -3.87899995F));
                    builder.AddCubicBezier(new Vector2(9.5F, -6.15500021F), new Vector2(7.65500021F, -8F), new Vector2(5.37900019F, -8F));
                    builder.AddCubicBezier(new Vector2(5.37900019F, -8F), new Vector2(-5.37900019F, -8F), new Vector2(-5.37900019F, -8F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - -  Offset:<120, 120>
            // - Path
            CanvasGeometry Geometry_1()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.BeginFigure(new Vector2(0F, -9.25F));
                    builder.AddCubicBezier(new Vector2(-5.11000013F, -9.25F), new Vector2(-9.25F, -5.11000013F), new Vector2(-9.25F, 0F));
                    builder.AddCubicBezier(new Vector2(-9.25F, 0F), new Vector2(-9.25F, 0.00999999978F), new Vector2(-9.25F, 0.00999999978F));
                    builder.AddCubicBezier(new Vector2(-9.25F, 5.11000013F), new Vector2(-5.11000013F, 9.25F), new Vector2(0F, 9.25F));
                    builder.AddCubicBezier(new Vector2(0F, 9.25F), new Vector2(0.00999999978F, 9.25F), new Vector2(0.00999999978F, 9.25F));
                    builder.AddCubicBezier(new Vector2(5.11000013F, 9.25F), new Vector2(9.25F, 5.11000013F), new Vector2(9.25F, 0.00999999978F));
                    builder.AddCubicBezier(new Vector2(9.25F, 0.00999999978F), new Vector2(9.25F, 0F), new Vector2(9.25F, 0F));
                    builder.AddCubicBezier(new Vector2(9.25F, -5.11000013F), new Vector2(5.11000013F, -9.25F), new Vector2(0.00999999978F, -9.25F));
                    builder.AddCubicBezier(new Vector2(0.00999999978F, -9.25F), new Vector2(0F, -9.25F), new Vector2(0F, -9.25F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - ShapeGroup: Shape Scale:10,10
            CanvasGeometry Geometry_2()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(5.86899996F, -2.99499989F));
                    builder.AddLine(new Vector2(3.87199998F, -3.00200009F));
                    builder.AddLine(new Vector2(3.77900004F, -2.99600005F));
                    builder.AddCubicBezier(new Vector2(3.477F, -2.9519999F), new Vector2(3.24600005F, -2.69300008F), new Vector2(3.24499989F, -2.37899995F));
                    builder.AddLine(new Vector2(3.24499989F, 2.36899996F));
                    builder.AddLine(new Vector2(3.25099993F, 2.46099997F));
                    builder.AddCubicBezier(new Vector2(3.296F, 2.76200008F), new Vector2(3.55599999F, 2.99399996F), new Vector2(3.86999989F, 2.99399996F));
                    builder.AddLine(new Vector2(3.96199989F, 2.98699999F));
                    builder.AddCubicBezier(new Vector2(4.26300001F, 2.94199991F), new Vector2(4.49499989F, 2.68300009F), new Vector2(4.49499989F, 2.36899996F));
                    builder.AddLine(new Vector2(4.49399996F, 1.25300002F));
                    builder.AddLine(new Vector2(5.6170001F, 1.25399995F));
                    builder.AddLine(new Vector2(5.70900011F, 1.24800003F));
                    builder.AddCubicBezier(new Vector2(6.01000023F, 1.20299995F), new Vector2(6.2420001F, 0.943000019F), new Vector2(6.2420001F, 0.629000008F));
                    builder.AddLine(new Vector2(6.23500013F, 0.537F));
                    builder.AddCubicBezier(new Vector2(6.19000006F, 0.236000001F), new Vector2(5.93100023F, 0.00400000019F), new Vector2(5.6170001F, 0.00400000019F));
                    builder.AddLine(new Vector2(4.49399996F, 0.00300000003F));
                    builder.AddLine(new Vector2(4.49399996F, -1.75100005F));
                    builder.AddLine(new Vector2(5.86499977F, -1.745F));
                    builder.AddLine(new Vector2(5.95699978F, -1.75199997F));
                    builder.AddCubicBezier(new Vector2(6.25899982F, -1.796F), new Vector2(6.49100018F, -2.0539999F), new Vector2(6.4920001F, -2.36800003F));
                    builder.AddCubicBezier(new Vector2(6.49300003F, -2.71300006F), new Vector2(6.21400023F, -2.99399996F), new Vector2(5.86899996F, -2.99499989F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(1.49399996F, -2.47000003F));
                    builder.AddCubicBezier(new Vector2(1.449F, -2.77099991F), new Vector2(1.19000006F, -3.00200009F), new Vector2(0.875999987F, -3.00200009F));
                    builder.AddCubicBezier(new Vector2(0.531000018F, -3.00200009F), new Vector2(0.250999987F, -2.72199988F), new Vector2(0.250999987F, -2.37700009F));
                    builder.AddLine(new Vector2(0.250999987F, 2.38499999F));
                    builder.AddLine(new Vector2(0.257999986F, 2.477F));
                    builder.AddCubicBezier(new Vector2(0.303000003F, 2.77800012F), new Vector2(0.561999977F, 3.00999999F), new Vector2(0.875999987F, 3.00999999F));
                    builder.AddCubicBezier(new Vector2(1.22099996F, 3.00999999F), new Vector2(1.50100005F, 2.73000002F), new Vector2(1.50100005F, 2.38499999F));
                    builder.AddLine(new Vector2(1.50100005F, -2.37700009F));
                    builder.AddLine(new Vector2(1.49399996F, -2.47000003F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-2.23600006F, -2.81100011F));
                    builder.AddCubicBezier(new Vector2(-2.7190001F, -3.04299998F), new Vector2(-3.14100003F, -3.12400007F), new Vector2(-3.73799992F, -3.12400007F));
                    builder.AddCubicBezier(new Vector2(-5.36399984F, -3.12400007F), new Vector2(-6.4920001F, -1.71500003F), new Vector2(-6.4920001F, -0.00200000009F));
                    builder.AddCubicBezier(new Vector2(-6.4920001F, 1.71099997F), new Vector2(-5.36399984F, 3.12400007F), new Vector2(-3.73799992F, 3.12400007F));
                    builder.AddCubicBezier(new Vector2(-2.79099989F, 3.12400007F), new Vector2(-1.92700005F, 2.63800001F), new Vector2(-1.551F, 1.74800003F));
                    builder.AddLine(new Vector2(-1.52999997F, 1.69299996F));
                    builder.AddLine(new Vector2(-1.50899994F, 1.60300004F));
                    builder.AddLine(new Vector2(-1.50300002F, 1.54799998F));
                    builder.AddLine(new Vector2(-1.50100005F, 0F));
                    builder.AddLine(new Vector2(-1.50800002F, -0.0920000002F));
                    builder.AddCubicBezier(new Vector2(-1.55299997F, -0.393000007F), new Vector2(-1.81200004F, -0.625F), new Vector2(-2.12599993F, -0.625F));
                    builder.AddLine(new Vector2(-3.12800002F, -0.625F));
                    builder.AddLine(new Vector2(-3.22000003F, -0.617999971F));
                    builder.AddCubicBezier(new Vector2(-3.52099991F, -0.573000014F), new Vector2(-3.75300002F, -0.31400001F), new Vector2(-3.75300002F, 0F));
                    builder.AddLine(new Vector2(-3.74600005F, 0.0920000002F));
                    builder.AddCubicBezier(new Vector2(-3.70099998F, 0.393000007F), new Vector2(-3.44199991F, 0.625F), new Vector2(-3.12800002F, 0.625F));
                    builder.AddLine(new Vector2(-2.75200009F, 0.624000013F));
                    builder.AddLine(new Vector2(-2.75200009F, 1.35800004F));
                    builder.AddLine(new Vector2(-2.7579999F, 1.37300003F));
                    builder.AddCubicBezier(new Vector2(-2.94700003F, 1.69400001F), new Vector2(-3.30900002F, 1.87399995F), new Vector2(-3.73799992F, 1.87399995F));
                    builder.AddCubicBezier(new Vector2(-4.60400009F, 1.87399995F), new Vector2(-5.2420001F, 1.07500005F), new Vector2(-5.2420001F, -0.00200000009F));
                    builder.AddCubicBezier(new Vector2(-5.2420001F, -1.07799995F), new Vector2(-4.60500002F, -1.87399995F), new Vector2(-3.73799992F, -1.87399995F));
                    builder.AddCubicBezier(new Vector2(-3.31699991F, -1.87399995F), new Vector2(-3.0769999F, -1.82799995F), new Vector2(-2.77699995F, -1.68400002F));
                    builder.AddCubicBezier(new Vector2(-2.46600008F, -1.53499997F), new Vector2(-2.09200001F, -1.66600001F), new Vector2(-1.94299996F, -1.977F));
                    builder.AddCubicBezier(new Vector2(-1.79400003F, -2.28800011F), new Vector2(-1.92499995F, -2.66199994F), new Vector2(-2.23600006F, -2.81100011F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Layer aggregator
            // - - ShapeGroup: Ellipse 20 Scale:10,10
            CanvasGeometry Geometry_3()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.BeginFigure(new Vector2(3.25F, 0F));
                    builder.AddCubicBezier(new Vector2(2.34500003F, 0.628000021F), new Vector2(1.21899998F, 1F), new Vector2(0F, 1F));
                    builder.AddCubicBezier(new Vector2(-1.21899998F, 1F), new Vector2(-2.34500003F, 0.628000021F), new Vector2(-3.25F, 0F));
                    builder.EndFigure(CanvasFigureLoop.Open);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_4()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(0F, -0.25F));
                    builder.AddCubicBezier(new Vector2(0.702000022F, -0.25F), new Vector2(1.25F, 0.298000008F), new Vector2(1.25F, 1F));
                    builder.AddCubicBezier(new Vector2(1.25F, 1.70200002F), new Vector2(0.702000022F, 2.25F), new Vector2(0F, 2.25F));
                    builder.AddCubicBezier(new Vector2(-0.702000022F, 2.25F), new Vector2(-1.25F, 1.70200002F), new Vector2(-1.25F, 1F));
                    builder.AddCubicBezier(new Vector2(-1.25F, 0.298000008F), new Vector2(-0.702000022F, -0.25F), new Vector2(0F, -0.25F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - Layer aggregator
            // Offset:<120, 120>
            // Color bound to theme property value: Color_000000
            CompositionColorBrush ThemeColor_Color_000000_0()
            {
                if (_themeColor_Color_000000_0 != null) { return _themeColor_Color_000000_0; }
                var result = _themeColor_Color_000000_0 = _c.CreateColorBrush();
                BindProperty(_themeColor_Color_000000_0, "Color", "ColorRGB(_theme.Color_000000.W,_theme.Color_000000.X,_theme.Color_000000.Y,_theme.Color_000000.Z)", "_theme", _themeProperties);
                return result;
            }

            // - - Layer aggregator
            // ShapeGroup: Shape Scale:10,10
            // Color bound to theme property value: Color_000000
            CompositionColorBrush ThemeColor_Color_000000_1()
            {
                if (_themeColor_Color_000000_1 != null) { return _themeColor_Color_000000_1; }
                var result = _themeColor_Color_000000_1 = _c.CreateColorBrush();
                var propertySet = result.Properties;
                propertySet.InsertScalar("Opacity0", 1F);
                BindProperty2(_themeColor_Color_000000_1, "Color", "ColorRGB(_theme.Color_000000.W*my.Opacity0,_theme.Color_000000.X,_theme.Color_000000.Y,_theme.Color_000000.Z)", "_theme", _themeProperties, "my", propertySet);
                return result;
            }

            // Color bound to theme property value: Color_000000
            CompositionColorBrush ThemeColor_Color_000000_2()
            {
                if (_themeColor_Color_000000_2 != null) { return _themeColor_Color_000000_2; }
                var result = _themeColor_Color_000000_2 = _c.CreateColorBrush();
                var propertySet = result.Properties;
                propertySet.InsertScalar("Opacity0", 0F);
                BindProperty2(_themeColor_Color_000000_2, "Color", "ColorRGB(_theme.Color_000000.W*my.Opacity0,_theme.Color_000000.X,_theme.Color_000000.Y,_theme.Color_000000.Z)", "_theme", _themeProperties, "my", propertySet);
                return result;
            }

            // Layer aggregator
            CompositionContainerShape ContainerShape_0()
            {
                if (_containerShape_0 != null) { return _containerShape_0; }
                var result = _containerShape_0 = _c.CreateContainerShape();
                result.Offset = new Vector2(117.529999F, 119.960999F);
                // ShapeGroup: Shape Scale:10,10
                result.Shapes.Add(SpriteShape_1());
                return result;
            }

            // Layer aggregator
            CompositionContainerShape ContainerShape_1()
            {
                if (_containerShape_1 != null) { return _containerShape_1; }
                var result = _containerShape_1 = _c.CreateContainerShape();
                var shapes = result.Shapes;
                // ShapeGroup: Ellipse 20 Scale:10,10
                shapes.Add(SpriteShape_2());
                // Transforms: 4 Offset:<30, -62.5>
                shapes.Add(SpriteShape_3());
                // Transforms: 3 Offset:<-30, -62.5>
                shapes.Add(SpriteShape_4());
                return result;
            }

            // - Layer aggregator
            // Offset:<120, 120>
            CompositionPathGeometry PathGeometry_0()
            {
                if (_pathGeometry_0 != null) { return _pathGeometry_0; }
                var result = _pathGeometry_0 = _c.CreatePathGeometry();
                return result;
            }

            // - - Layer aggregator
            // ShapeGroup: Shape Scale:10,10
            CompositionPathGeometry PathGeometry_1()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_2()));
            }

            // - - Layer aggregator
            // ShapeGroup: Ellipse 20 Scale:10,10
            CompositionPathGeometry PathGeometry_2()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_3()));
            }

            CompositionPathGeometry PathGeometry_3()
            {
                return (_pathGeometry_3 == null)
                    ? _pathGeometry_3 = _c.CreatePathGeometry(new CompositionPath(Geometry_4()))
                    : _pathGeometry_3;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_0()
            {
                // Offset:<120, 120>, Scale:<10, 10>
                var result = CreateSpriteShape(PathGeometry_0(), new Matrix3x2(10F, 0F, 0F, 10F, 120F, 120F));;
                result.StrokeBrush = ThemeColor_Color_000000_0();
                result.StrokeDashCap = CompositionStrokeCap.Round;
                result.StrokeStartCap = CompositionStrokeCap.Round;
                result.StrokeEndCap = CompositionStrokeCap.Round;
                result.StrokeLineJoin = CompositionStrokeLineJoin.Round;
                result.StrokeMiterLimit = 2F;
                result.StrokeThickness = 1.5F;
                return result;
            }

            // - Layer aggregator
            // ShapeGroup: Shape Scale:10,10
            CompositionSpriteShape SpriteShape_1()
            {
                // Scale:<10, 10>
                var geometry = PathGeometry_1();
                var result = CreateSpriteShape(geometry, new Matrix3x2(10F, 0F, 0F, 10F, 0F, 0F), ThemeColor_Color_000000_1());;
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_2()
            {
                // Scale:<10, 10>
                var result = CreateSpriteShape(PathGeometry_2(), new Matrix3x2(10F, 0F, 0F, 10F, 0F, 0F));;
                result.StrokeBrush = ThemeColor_Color_000000_2();
                result.StrokeDashCap = CompositionStrokeCap.Round;
                result.StrokeStartCap = CompositionStrokeCap.Round;
                result.StrokeEndCap = CompositionStrokeCap.Round;
                result.StrokeMiterLimit = 2F;
                result.StrokeThickness = 1.5F;
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_3()
            {
                // Offset:<30, -62.5>, Scale:<10, 10>
                var geometry = PathGeometry_3();
                var result = CreateSpriteShape(geometry, new Matrix3x2(10F, 0F, 0F, 10F, 30F, -62.5F), ThemeColor_Color_000000_2());;
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_4()
            {
                // Offset:<-30, -62.5>, Scale:<10, 10>
                var geometry = PathGeometry_3();
                var result = CreateSpriteShape(geometry, new Matrix3x2(10F, 0F, 0F, 10F, -30F, -62.5F), ThemeColor_Color_000000_2());;
                return result;
            }

            // The root of the composition.
            ContainerVisual Root()
            {
                if (_root != null) { return _root; }
                var result = _root = _c.CreateContainerVisual();
                var propertySet = result.Properties;
                propertySet.InsertScalar("Progress", 0F);
                // Layer aggregator
                result.Children.InsertAtTop(ShapeVisual_0());
                return result;
            }

            CubicBezierEasingFunction CubicBezierEasingFunction_0()
            {
                return (_cubicBezierEasingFunction_0 == null)
                    ? _cubicBezierEasingFunction_0 = _c.CreateCubicBezierEasingFunction(new Vector2(0.600000024F, 0F), new Vector2(0.400000006F, 1F))
                    : _cubicBezierEasingFunction_0;
            }

            ExpressionAnimation RootProgress()
            {
                if (_rootProgress != null) { return _rootProgress; }
                var result = _rootProgress = _c.CreateExpressionAnimation("_.Progress");
                result.SetReferenceParameter("_", _root);
                return result;
            }

            // - - Layer aggregator
            // -  Offset:<120, 120>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_0()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, new CompositionPath(Geometry_0()), HoldThenStepEasingFunction());
                // Frame 12.
                result.InsertKeyFrame(0.600000024F, new CompositionPath(Geometry_1()), CubicBezierEasingFunction_0());
                return result;
            }

            // Opacity0
            ScalarKeyFrameAnimation Opacity0ScalarAnimation_0_to_1()
            {
                // Frame 0.
                var result = CreateScalarKeyFrameAnimation(0F, 0F, StepThenHoldEasingFunction());
                // Frame 4.
                result.InsertKeyFrame(0.200000003F, 0F, HoldThenStepEasingFunction());
                // Frame 12.
                result.InsertKeyFrame(0.600000024F, 1F, CubicBezierEasingFunction_0());
                return result;
            }

            // Opacity0
            ScalarKeyFrameAnimation Opacity0ScalarAnimation_1_to_0()
            {
                // Frame 0.
                var result = CreateScalarKeyFrameAnimation(0F, 1F, HoldThenStepEasingFunction());
                // Frame 8.
                result.InsertKeyFrame(0.400000006F, 0F, CubicBezierEasingFunction_0());
                return result;
            }

            // Layer aggregator
            ShapeVisual ShapeVisual_0()
            {
                var result = _c.CreateShapeVisual();
                result.Size = new Vector2(240F, 240F);
                var shapes = result.Shapes;
                // Offset:<120, 120>
                shapes.Add(SpriteShape_0());
                shapes.Add(ContainerShape_0());
                shapes.Add(ContainerShape_1());
                return result;
            }

            StepEasingFunction HoldThenStepEasingFunction()
            {
                if (_holdThenStepEasingFunction != null) { return _holdThenStepEasingFunction; }
                var result = _holdThenStepEasingFunction = _c.CreateStepEasingFunction();
                result.IsFinalStepSingleFrame = true;
                return result;
            }

            // Opacity0
            StepEasingFunction StepThenHoldEasingFunction()
            {
                var result = _c.CreateStepEasingFunction();
                result.IsInitialStepSingleFrame = true;
                return result;
            }

            // - Layer aggregator
            // Offset
            Vector2KeyFrameAnimation OffsetVector2Animation()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(120F, 132.5F), HoldThenStepEasingFunction());
                // Frame 12.
                result.InsertKeyFrame(0.600000024F, new Vector2(120F, 152.5F), CubicBezierEasingFunction_0());
                return result;
            }

            // - Layer aggregator
            // Scale
            Vector2KeyFrameAnimation ScaleVector2Animation_0()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(1F, 1F), HoldThenStepEasingFunction());
                // Frame 12.
                result.InsertKeyFrame(0.600000024F, new Vector2(0.5F, 0.5F), CubicBezierEasingFunction_0());
                return result;
            }

            // - Layer aggregator
            // Scale
            Vector2KeyFrameAnimation ScaleVector2Animation_1()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(0.5F, 0.5F), HoldThenStepEasingFunction());
                // Frame 12.
                result.InsertKeyFrame(0.600000024F, new Vector2(1F, 1F), CubicBezierEasingFunction_0());
                return result;
            }

            internal GifToEmoji_AnimatedVisual_UAPv11(
                Compositor compositor,
                CompositionPropertySet themeProperties
                )
            {
                _c = compositor;
                _themeProperties = themeProperties;
                _reusableExpressionAnimation = compositor.CreateExpressionAnimation();
                Root();
            }

            public Visual RootVisual => _root;
            public TimeSpan Duration => TimeSpan.FromTicks(c_durationTicks);
            public Vector2 Size => new Vector2(240F, 240F);
            void IDisposable.Dispose() => _root?.Dispose();

            public void CreateAnimations()
            {
                StartProgressBoundAnimation(_themeColor_Color_000000_1.Properties, "Opacity0", Opacity0ScalarAnimation_1_to_0(), RootProgress());
                StartProgressBoundAnimation(_themeColor_Color_000000_2.Properties, "Opacity0", Opacity0ScalarAnimation_0_to_1(), RootProgress());
                StartProgressBoundAnimation(_containerShape_0, "Scale", ScaleVector2Animation_0(), RootProgress());
                StartProgressBoundAnimation(_containerShape_1, "Scale", ScaleVector2Animation_1(), RootProgress());
                StartProgressBoundAnimation(_containerShape_1, "Offset", OffsetVector2Animation(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_0, "Path", PathKeyFrameAnimation_0(), RootProgress());
            }

            public void DestroyAnimations()
            {
                _themeColor_Color_000000_1.Properties.StopAnimation("Opacity0");
                _themeColor_Color_000000_2.Properties.StopAnimation("Opacity0");
                _containerShape_0.StopAnimation("Scale");
                _containerShape_1.StopAnimation("Scale");
                _containerShape_1.StopAnimation("Offset");
                _pathGeometry_0.StopAnimation("Path");
            }

            internal static bool IsRuntimeCompatible()
            {
                return Windows.Foundation.Metadata.ApiInformation.IsApiContractPresent("Windows.Foundation.UniversalApiContract", 11);
            }
        }
    }
}
