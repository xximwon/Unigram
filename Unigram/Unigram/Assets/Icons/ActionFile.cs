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
//           7.1.0+ge1fa92580f
//       
//       Command:
//           LottieGen -Language CSharp -Namespace Unigram.Assets.Icons -Public -WinUIVersion 2.7 -InputFile ActionFile.json
//       
//       Input file:
//           ActionFile.json (3707 bytes created 16:38+01:00 Dec 22 2021)
//       
//       LottieGen source:
//           http://aka.ms/Lottie
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// __________________________________________________________
// |       Object stats       | UAP v8 count | UAP v7 count |
// |__________________________|______________|______________|
// | All CompositionObjects   |           46 |           24 |
// |--------------------------+--------------+--------------|
// | Expression animators     |            1 |            1 |
// | KeyFrame animators       |            1 |            1 |
// | Reference parameters     |            1 |            1 |
// | Expression operations    |            0 |            0 |
// |--------------------------+--------------+--------------|
// | Animated brushes         |            - |            - |
// | Animated gradient stops  |            - |            - |
// | ExpressionAnimations     |            1 |            1 |
// | PathKeyFrameAnimations   |            - |            - |
// |--------------------------+--------------+--------------|
// | ContainerVisuals         |            3 |            1 |
// | ShapeVisuals             |            2 |            1 |
// |--------------------------+--------------+--------------|
// | ContainerShapes          |            - |            - |
// | CompositionSpriteShapes  |            3 |            2 |
// |--------------------------+--------------+--------------|
// | Brushes                  |            5 |            2 |
// | Gradient stops           |            - |            - |
// | CompositionVisualSurface |            2 |            - |
// ----------------------------------------------------------
using Microsoft.Graphics.Canvas;
using Microsoft.Graphics.Canvas.Effects;
using Microsoft.Graphics.Canvas.Geometry;
using System;
using System.Collections.Generic;
using System.Numerics;
using Windows.Graphics;
using Windows.UI;
using Windows.UI.Composition;

namespace Unigram.Assets.Icons
{
    // Name:        u_sending_file
    // Frame rate:  60 fps
    // Frame count: 60
    // Duration:    1000.0 mS
    public sealed class ActionFile
        : Microsoft.UI.Xaml.Controls.IAnimatedVisualSource
        , Microsoft.UI.Xaml.Controls.IAnimatedVisualSource2
    {
        // Animation duration: 1.000 seconds.
        internal const long c_durationTicks = 10000000;
        internal readonly Color m_foreground;

        public ActionFile(Color foreground)
        {
            m_foreground = foreground;
        }

        public Microsoft.UI.Xaml.Controls.IAnimatedVisual TryCreateAnimatedVisual(Compositor compositor)
        {
            object ignored = null;
            return TryCreateAnimatedVisual(compositor, out ignored);
        }

        public Microsoft.UI.Xaml.Controls.IAnimatedVisual TryCreateAnimatedVisual(Compositor compositor, out object diagnostics)
        {
            diagnostics = null;

            if (ActionFile_AnimatedVisual_UAPv8.IsRuntimeCompatible())
            {
                return
                    new ActionFile_AnimatedVisual_UAPv8(
                        compositor,
                        m_foreground
                        );
            }

            if (ActionFile_AnimatedVisual_UAPv7.IsRuntimeCompatible())
            {
                return
                    new ActionFile_AnimatedVisual_UAPv7(
                        compositor,
                        m_foreground
                        );
            }

            return null;
        }

        /// <summary>
        /// Gets the number of frames in the animation.
        /// </summary>
        public double FrameCount => 60d;

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
            return frameNumber / 60d;
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
        }

        /// <summary>
        /// Sets the scalar property with the given name, or does nothing if no such property
        /// exists.
        /// </summary>
        public void SetScalarProperty(string propertyName, double value)
        {
        }

        sealed class ActionFile_AnimatedVisual_UAPv8 : Microsoft.UI.Xaml.Controls.IAnimatedVisual
        {
            const long c_durationTicks = 10000000;
            readonly Compositor _c;
            readonly Color _f;
            readonly ExpressionAnimation _reusableExpressionAnimation;
            CompositionColorBrush _colorBrush_Black;
            CompositionPathGeometry _pathGeometry_0;
            ContainerVisual _root;

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

            Vector2KeyFrameAnimation CreateVector2KeyFrameAnimation(float initialProgress, Vector2 initialValue, CompositionEasingFunction initialEasingFunction)
            {
                var result = _c.CreateVector2KeyFrameAnimation();
                result.Duration = TimeSpan.FromTicks(c_durationTicks);
                result.InsertKeyFrame(initialProgress, initialValue, initialEasingFunction);
                return result;
            }

            CompositionSpriteShape CreateSpriteShape(CompositionGeometry geometry, Matrix3x2 transformMatrix, CompositionBrush fillBrush)
            {
                var result = _c.CreateSpriteShape(geometry);
                result.TransformMatrix = transformMatrix;
                result.FillBrush = fillBrush;
                return result;
            }

            CanvasGeometry Geometry_0()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-46.8400002F, -15F));
                    builder.AddLine(new Vector2(46.8400002F, -15F));
                    builder.AddCubicBezier(new Vector2(52.7799988F, -15F), new Vector2(56.5089989F, -14.0719995F), new Vector2(59.7680016F, -12.3290005F));
                    builder.AddCubicBezier(new Vector2(63.0270004F, -10.5860004F), new Vector2(65.5859985F, -8.02799988F), new Vector2(67.3290024F, -4.76900005F));
                    builder.AddCubicBezier(new Vector2(69.0719986F, -1.50999999F), new Vector2(70F, 2.22000003F), new Vector2(70F, 8.15999985F));
                    builder.AddLine(new Vector2(70F, 11.8400002F));
                    builder.AddCubicBezier(new Vector2(70F, 17.7800007F), new Vector2(69.0719986F, 21.5090008F), new Vector2(67.3290024F, 24.7679996F));
                    builder.AddCubicBezier(new Vector2(65.5859985F, 28.0270004F), new Vector2(63.0270004F, 30.5860004F), new Vector2(59.7680016F, 32.3289986F));
                    builder.AddCubicBezier(new Vector2(56.5089989F, 34.0719986F), new Vector2(52.7799988F, 35F), new Vector2(46.8400002F, 35F));
                    builder.AddLine(new Vector2(-46.8400002F, 35F));
                    builder.AddCubicBezier(new Vector2(-52.7799988F, 35F), new Vector2(-56.5089989F, 34.0719986F), new Vector2(-59.7680016F, 32.3289986F));
                    builder.AddCubicBezier(new Vector2(-63.0270004F, 30.5860004F), new Vector2(-65.5859985F, 28.0270004F), new Vector2(-67.3290024F, 24.7679996F));
                    builder.AddCubicBezier(new Vector2(-69.0719986F, 21.5090008F), new Vector2(-70F, 17.7800007F), new Vector2(-70F, 11.8400002F));
                    builder.AddLine(new Vector2(-70F, 8.15999985F));
                    builder.AddCubicBezier(new Vector2(-70F, 2.22000003F), new Vector2(-69.0719986F, -1.50999999F), new Vector2(-67.3290024F, -4.76900005F));
                    builder.AddCubicBezier(new Vector2(-65.5859985F, -8.02799988F), new Vector2(-63.0270004F, -10.5860004F), new Vector2(-59.7680016F, -12.3290005F));
                    builder.AddCubicBezier(new Vector2(-56.5089989F, -14.0719995F), new Vector2(-52.7799988F, -15F), new Vector2(-46.8400002F, -15F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Masks
            CanvasGeometry Geometry_1()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.BeginFigure(new Vector2(53.6599998F, 85.5F));
                    builder.AddLine(new Vector2(147.339996F, 85.5F));
                    builder.AddCubicBezier(new Vector2(153.279999F, 85.5F), new Vector2(157.009003F, 86.4280014F), new Vector2(160.268005F, 88.1709976F));
                    builder.AddCubicBezier(new Vector2(163.526993F, 89.9140015F), new Vector2(166.085999F, 92.4729996F), new Vector2(167.828995F, 95.7320023F));
                    builder.AddCubicBezier(new Vector2(169.572006F, 98.9909973F), new Vector2(170.5F, 102.720001F), new Vector2(170.5F, 108.660004F));
                    builder.AddLine(new Vector2(170.5F, 112.339996F));
                    builder.AddCubicBezier(new Vector2(170.5F, 118.279999F), new Vector2(169.572006F, 122.009003F), new Vector2(167.828995F, 125.267998F));
                    builder.AddCubicBezier(new Vector2(166.085999F, 128.526993F), new Vector2(163.526993F, 131.085999F), new Vector2(160.268005F, 132.828995F));
                    builder.AddCubicBezier(new Vector2(157.009003F, 134.572006F), new Vector2(153.279999F, 135.5F), new Vector2(147.339996F, 135.5F));
                    builder.AddLine(new Vector2(53.6599998F, 135.5F));
                    builder.AddCubicBezier(new Vector2(47.7200012F, 135.5F), new Vector2(43.9910011F, 134.572006F), new Vector2(40.7319984F, 132.828995F));
                    builder.AddCubicBezier(new Vector2(37.4729996F, 131.085999F), new Vector2(34.9140015F, 128.526993F), new Vector2(33.1710014F, 125.267998F));
                    builder.AddCubicBezier(new Vector2(31.4279995F, 122.009003F), new Vector2(30.5F, 118.279999F), new Vector2(30.5F, 112.339996F));
                    builder.AddLine(new Vector2(30.5F, 108.660004F));
                    builder.AddCubicBezier(new Vector2(30.5F, 102.720001F), new Vector2(31.4279995F, 98.9909973F), new Vector2(33.1710014F, 95.7320023F));
                    builder.AddCubicBezier(new Vector2(34.9140015F, 92.4729996F), new Vector2(37.4729996F, 89.9140015F), new Vector2(40.7319984F, 88.1709976F));
                    builder.AddCubicBezier(new Vector2(43.9910011F, 86.4280014F), new Vector2(47.7200012F, 85.5F), new Vector2(53.6599998F, 85.5F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CompositionColorBrush ColorBrush_Black()
            {
                return _colorBrush_Black = _c.CreateColorBrush(Color.FromArgb(0xFF, _f.R, _f.G, _f.B));
            }

            // - Shape tree root for layer: icon
            // ShapeGroup: Group 1 Offset:<100, 100>
            CompositionColorBrush ColorBrush_SemiTransparentBlack()
            {
                return _c.CreateColorBrush(Color.FromArgb(0x66, _f.R, _f.G, _f.B));
            }

            CompositionEffectBrush EffectBrush()
            {
                var compositeEffect = new CompositeEffect();
                compositeEffect.Mode = CanvasComposite.DestinationIn;
                compositeEffect.Sources.Add(new CompositionEffectSourceParameter("destination"));
                compositeEffect.Sources.Add(new CompositionEffectSourceParameter("source"));
                var effectFactory = _c.CreateEffectFactory(compositeEffect);
                var result = effectFactory.CreateBrush();
                result.SetSourceParameter("destination", SurfaceBrush_0());
                result.SetSourceParameter("source", SurfaceBrush_1());
                return result;
            }

            CompositionPathGeometry PathGeometry_0()
            {
                return _pathGeometry_0 = _c.CreatePathGeometry(new CompositionPath(Geometry_0()));
            }

            // - Masks
            CompositionPathGeometry PathGeometry_1()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_1()));
            }

            // Shape tree root for layer: icon
            // Path 1
            CompositionSpriteShape SpriteShape_0()
            {
                // Offset:<100, 100>
                var geometry = PathGeometry_0();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 100F, 100F), ColorBrush_SemiTransparentBlack());
                return result;
            }

            // Shape tree root for layer: icon
            // Path 1
            CompositionSpriteShape SpriteShape_1()
            {
                var result = _c.CreateSpriteShape(_pathGeometry_0);
                result.FillBrush = ColorBrush_Black();
                result.StartAnimation("Offset", OffsetVector2Animation());
                var controller = result.TryGetAnimationController("Offset");
                controller.Pause();
                BindProperty(controller, "Progress", "_.Progress", "_", _root);
                return result;
            }

            // Masks
            CompositionSpriteShape SpriteShape_2()
            {
                var result = _c.CreateSpriteShape(PathGeometry_1());
                result.FillBrush = _colorBrush_Black;
                return result;
            }

            CompositionSurfaceBrush SurfaceBrush_0()
            {
                return _c.CreateSurfaceBrush(VisualSurface_0());
            }

            CompositionSurfaceBrush SurfaceBrush_1()
            {
                return _c.CreateSurfaceBrush(VisualSurface_1());
            }

            CompositionVisualSurface VisualSurface_0()
            {
                var result = _c.CreateVisualSurface();
                result.SourceVisual = ContainerVisual_0();
                result.SourceSize = new Vector2(200F, 200F);
                return result;
            }

            CompositionVisualSurface VisualSurface_1()
            {
                var result = _c.CreateVisualSurface();
                result.SourceVisual = ContainerVisual_1();
                result.SourceSize = new Vector2(200F, 200F);
                return result;
            }

            ContainerVisual ContainerVisual_0()
            {
                var result = _c.CreateContainerVisual();
                result.BorderMode = CompositionBorderMode.Soft;
                // Shape tree root for layer: icon
                result.Children.InsertAtTop(ShapeVisual_0());
                return result;
            }

            ContainerVisual ContainerVisual_1()
            {
                var result = _c.CreateContainerVisual();
                result.BorderMode = CompositionBorderMode.Soft;
                // Masks
                result.Children.InsertAtTop(ShapeVisual_1());
                return result;
            }

            // The root of the composition.
            ContainerVisual Root()
            {
                var result = _root = _c.CreateContainerVisual();
                var propertySet = result.Properties;
                propertySet.InsertScalar("Progress", 0F);
                result.Children.InsertAtTop(SpriteVisual_0());
                return result;
            }

            // Shape tree root for layer: icon
            ShapeVisual ShapeVisual_0()
            {
                var result = _c.CreateShapeVisual();
                result.Size = new Vector2(200F, 200F);
                var shapes = result.Shapes;
                // ShapeGroup: Group 1 Offset:<100, 100>
                shapes.Add(SpriteShape_0());
                // ShapeGroup: Group 2
                shapes.Add(SpriteShape_1());
                return result;
            }

            // Masks
            ShapeVisual ShapeVisual_1()
            {
                var result = _c.CreateShapeVisual();
                result.Size = new Vector2(200F, 200F);
                result.Shapes.Add(SpriteShape_2());
                return result;
            }

            SpriteVisual SpriteVisual_0()
            {
                var result = _c.CreateSpriteVisual();
                result.Size = new Vector2(200F, 200F);
                result.Brush = EffectBrush();
                return result;
            }

            // - - Shape tree root for layer: icon
            // - ShapeGroup: Group 2
            // Offset
            StepEasingFunction HoldThenStepEasingFunction()
            {
                var result = _c.CreateStepEasingFunction();
                result.IsFinalStepSingleFrame = true;
                return result;
            }

            // - Shape tree root for layer: icon
            // ShapeGroup: Group 2
            // Offset
            Vector2KeyFrameAnimation OffsetVector2Animation()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(-40F, 100F), HoldThenStepEasingFunction());
                // Frame 59.
                result.InsertKeyFrame(0.983333349F, new Vector2(240F, 100F), _c.CreateCubicBezierEasingFunction(new Vector2(0.166999996F, 0.166999996F), new Vector2(0.833000004F, 0.833000004F)));
                return result;
            }

            internal ActionFile_AnimatedVisual_UAPv8(
                Compositor compositor,
                Color foreground
                )
            {
                _c = compositor;
                _f = foreground;
                _reusableExpressionAnimation = compositor.CreateExpressionAnimation();
                Root();
            }

            public Visual RootVisual => _root;
            public TimeSpan Duration => TimeSpan.FromTicks(c_durationTicks);
            public Vector2 Size => new Vector2(200F, 200F);
            void IDisposable.Dispose() => _root?.Dispose();

            internal static bool IsRuntimeCompatible()
            {
                return Windows.Foundation.Metadata.ApiInformation.IsApiContractPresent("Windows.Foundation.UniversalApiContract", 8);
            }
        }

        sealed class ActionFile_AnimatedVisual_UAPv7 : Microsoft.UI.Xaml.Controls.IAnimatedVisual
        {
            const long c_durationTicks = 10000000;
            readonly Compositor _c;
            readonly Color _f;
            readonly ExpressionAnimation _reusableExpressionAnimation;
            CompositionPathGeometry _pathGeometry;
            ContainerVisual _root;

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

            Vector2KeyFrameAnimation CreateVector2KeyFrameAnimation(float initialProgress, Vector2 initialValue, CompositionEasingFunction initialEasingFunction)
            {
                var result = _c.CreateVector2KeyFrameAnimation();
                result.Duration = TimeSpan.FromTicks(c_durationTicks);
                result.InsertKeyFrame(initialProgress, initialValue, initialEasingFunction);
                return result;
            }

            CompositionSpriteShape CreateSpriteShape(CompositionGeometry geometry, Matrix3x2 transformMatrix, CompositionBrush fillBrush)
            {
                var result = _c.CreateSpriteShape(geometry);
                result.TransformMatrix = transformMatrix;
                result.FillBrush = fillBrush;
                return result;
            }

            CanvasGeometry Geometry()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-46.8400002F, -15F));
                    builder.AddLine(new Vector2(46.8400002F, -15F));
                    builder.AddCubicBezier(new Vector2(52.7799988F, -15F), new Vector2(56.5089989F, -14.0719995F), new Vector2(59.7680016F, -12.3290005F));
                    builder.AddCubicBezier(new Vector2(63.0270004F, -10.5860004F), new Vector2(65.5859985F, -8.02799988F), new Vector2(67.3290024F, -4.76900005F));
                    builder.AddCubicBezier(new Vector2(69.0719986F, -1.50999999F), new Vector2(70F, 2.22000003F), new Vector2(70F, 8.15999985F));
                    builder.AddLine(new Vector2(70F, 11.8400002F));
                    builder.AddCubicBezier(new Vector2(70F, 17.7800007F), new Vector2(69.0719986F, 21.5090008F), new Vector2(67.3290024F, 24.7679996F));
                    builder.AddCubicBezier(new Vector2(65.5859985F, 28.0270004F), new Vector2(63.0270004F, 30.5860004F), new Vector2(59.7680016F, 32.3289986F));
                    builder.AddCubicBezier(new Vector2(56.5089989F, 34.0719986F), new Vector2(52.7799988F, 35F), new Vector2(46.8400002F, 35F));
                    builder.AddLine(new Vector2(-46.8400002F, 35F));
                    builder.AddCubicBezier(new Vector2(-52.7799988F, 35F), new Vector2(-56.5089989F, 34.0719986F), new Vector2(-59.7680016F, 32.3289986F));
                    builder.AddCubicBezier(new Vector2(-63.0270004F, 30.5860004F), new Vector2(-65.5859985F, 28.0270004F), new Vector2(-67.3290024F, 24.7679996F));
                    builder.AddCubicBezier(new Vector2(-69.0719986F, 21.5090008F), new Vector2(-70F, 17.7800007F), new Vector2(-70F, 11.8400002F));
                    builder.AddLine(new Vector2(-70F, 8.15999985F));
                    builder.AddCubicBezier(new Vector2(-70F, 2.22000003F), new Vector2(-69.0719986F, -1.50999999F), new Vector2(-67.3290024F, -4.76900005F));
                    builder.AddCubicBezier(new Vector2(-65.5859985F, -8.02799988F), new Vector2(-63.0270004F, -10.5860004F), new Vector2(-59.7680016F, -12.3290005F));
                    builder.AddCubicBezier(new Vector2(-56.5089989F, -14.0719995F), new Vector2(-52.7799988F, -15F), new Vector2(-46.8400002F, -15F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - Shape tree root for layer: icon
            // ShapeGroup: Group 2
            CompositionColorBrush ColorBrush_Black()
            {
                return _c.CreateColorBrush(Color.FromArgb(0xFF, _f.R, _f.G, _f.B));
            }

            // - Shape tree root for layer: icon
            // ShapeGroup: Group 1 Offset:<100, 100>
            CompositionColorBrush ColorBrush_SemiTransparentBlack()
            {
                return _c.CreateColorBrush(Color.FromArgb(0x66, _f.R, _f.G, _f.B));
            }

            CompositionPathGeometry PathGeometry()
            {
                return _pathGeometry = _c.CreatePathGeometry(new CompositionPath(Geometry()));
            }

            // Shape tree root for layer: icon
            // Path 1
            CompositionSpriteShape SpriteShape_0()
            {
                // Offset:<100, 100>
                var geometry = PathGeometry();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 100F, 100F), ColorBrush_SemiTransparentBlack());
                return result;
            }

            // Shape tree root for layer: icon
            // Path 1
            CompositionSpriteShape SpriteShape_1()
            {
                var result = _c.CreateSpriteShape(_pathGeometry);
                result.FillBrush = ColorBrush_Black();
                result.StartAnimation("Offset", OffsetVector2Animation());
                var controller = result.TryGetAnimationController("Offset");
                controller.Pause();
                BindProperty(controller, "Progress", "_.Progress", "_", _root);
                return result;
            }

            // The root of the composition.
            ContainerVisual Root()
            {
                var result = _root = _c.CreateContainerVisual();
                var propertySet = result.Properties;
                propertySet.InsertScalar("Progress", 0F);
                // Shape tree root for layer: icon
                result.Children.InsertAtTop(ShapeVisual_0());
                return result;
            }

            // Shape tree root for layer: icon
            ShapeVisual ShapeVisual_0()
            {
                var result = _c.CreateShapeVisual();
                result.Size = new Vector2(200F, 200F);
                var shapes = result.Shapes;
                // ShapeGroup: Group 1 Offset:<100, 100>
                shapes.Add(SpriteShape_0());
                // ShapeGroup: Group 2
                shapes.Add(SpriteShape_1());
                return result;
            }

            // - - Shape tree root for layer: icon
            // - ShapeGroup: Group 2
            // Offset
            StepEasingFunction HoldThenStepEasingFunction()
            {
                var result = _c.CreateStepEasingFunction();
                result.IsFinalStepSingleFrame = true;
                return result;
            }

            // - Shape tree root for layer: icon
            // ShapeGroup: Group 2
            // Offset
            Vector2KeyFrameAnimation OffsetVector2Animation()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(-40F, 100F), HoldThenStepEasingFunction());
                // Frame 59.
                result.InsertKeyFrame(0.983333349F, new Vector2(240F, 100F), _c.CreateCubicBezierEasingFunction(new Vector2(0.166999996F, 0.166999996F), new Vector2(0.833000004F, 0.833000004F)));
                return result;
            }

            internal ActionFile_AnimatedVisual_UAPv7(
                Compositor compositor,
                Color foreground
                )
            {
                _c = compositor;
                _f = foreground;
                _reusableExpressionAnimation = compositor.CreateExpressionAnimation();
                Root();
            }

            public Visual RootVisual => _root;
            public TimeSpan Duration => TimeSpan.FromTicks(c_durationTicks);
            public Vector2 Size => new Vector2(200F, 200F);
            void IDisposable.Dispose() => _root?.Dispose();

            internal static bool IsRuntimeCompatible()
            {
                return Windows.Foundation.Metadata.ApiInformation.IsApiContractPresent("Windows.Foundation.UniversalApiContract", 7);
            }
        }
    }
}
