﻿// Copyright (c) Josef Pihrt and Contributors. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

// <auto-generated>

using System.Collections.Generic;
using Roslynator.CSharp.Refactorings;

namespace Roslynator.VisualStudio
{
    public partial class RefactoringsOptionsPage
    {
        protected override string MaxId { get; } = RefactoringIdentifiers.AddAllPropertiesToInitializer;
        internal static void SetRefactoringsDisabledByDefault(RefactoringSettings settings)
        {
            settings.Disable(RefactoringIdentifiers.ConvertForEachToForAndReverseLoop);
            settings.Disable(RefactoringIdentifiers.ExpandInitializer);
            settings.Disable(RefactoringIdentifiers.IntroduceConstructor);
            settings.Disable(RefactoringIdentifiers.RemoveAllDocumentationComments);
            settings.Disable(RefactoringIdentifiers.ReplaceMethodWithProperty);
            settings.Disable(RefactoringIdentifiers.UseStringEmptyInsteadOfEmptyStringLiteral);
        }

        protected override void Fill(ICollection<BaseModel> refactorings)
        {
            refactorings.Clear();
            refactorings.Add(new BaseModel(RefactoringIdentifiers.AddBraces, "Add braces", IsEnabled(RefactoringIdentifiers.AddBraces)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.AddBracesToIfElse, "Add braces to if-else", IsEnabled(RefactoringIdentifiers.AddBracesToIfElse)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.AddBracesToSwitchSection, "Add braces to switch section", IsEnabled(RefactoringIdentifiers.AddBracesToSwitchSection)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.AddBracesToSwitchSections, "Add braces to switch sections", IsEnabled(RefactoringIdentifiers.AddBracesToSwitchSections)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.AddExplicitCast, "Add explicit cast", IsEnabled(RefactoringIdentifiers.AddExplicitCast)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.AddDefaultValueToParameter, "Add default value to parameter", IsEnabled(RefactoringIdentifiers.AddDefaultValueToParameter)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.AddExceptionElementToDocumentationComment, "Add 'exception' element to documentation comment", IsEnabled(RefactoringIdentifiers.AddExceptionElementToDocumentationComment)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.AddParameterNameToArgument, "Add parameter name to argument", IsEnabled(RefactoringIdentifiers.AddParameterNameToArgument)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.AddUsingDirective, "Add using directive", IsEnabled(RefactoringIdentifiers.AddUsingDirective)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.AddUsingStaticDirective, "Add using static directive", IsEnabled(RefactoringIdentifiers.AddUsingStaticDirective)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.CallExtensionMethodAsInstanceMethod, "Call extension method as instance method", IsEnabled(RefactoringIdentifiers.CallExtensionMethodAsInstanceMethod)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.UseImplicitType, "Use implicit type", IsEnabled(RefactoringIdentifiers.UseImplicitType)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ChangeMethodReturnTypeToVoid, "Change method return type to 'void'", IsEnabled(RefactoringIdentifiers.ChangeMethodReturnTypeToVoid)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ChangeTypeAccordingToExpression, "Change type according to expression", IsEnabled(RefactoringIdentifiers.ChangeTypeAccordingToExpression)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.UseExplicitType, "Use explicit type", IsEnabled(RefactoringIdentifiers.UseExplicitType)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.CheckExpressionForNull, "Check expression for null", IsEnabled(RefactoringIdentifiers.CheckExpressionForNull)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.CheckParameterForNull, "Check parameter for null", IsEnabled(RefactoringIdentifiers.CheckParameterForNull)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.InitializePropertiesInInitializer, "Initialize properties in a initializer", IsEnabled(RefactoringIdentifiers.InitializePropertiesInInitializer)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.CommentOutMemberDeclaration, "Comment out member declaration", IsEnabled(RefactoringIdentifiers.CommentOutMemberDeclaration)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.CommentOutStatement, "Comment out statement", IsEnabled(RefactoringIdentifiers.CommentOutStatement)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.CopyDocumentationCommentFromBaseMember, "Copy documentation comment from base member", IsEnabled(RefactoringIdentifiers.CopyDocumentationCommentFromBaseMember)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.DuplicateArgument, "Duplicate argument", IsEnabled(RefactoringIdentifiers.DuplicateArgument)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.DuplicateMember, "Duplicate member", IsEnabled(RefactoringIdentifiers.DuplicateMember)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.DuplicateParameter, "Duplicate parameter", IsEnabled(RefactoringIdentifiers.DuplicateParameter)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.DuplicateStatement, "Duplicate statement", IsEnabled(RefactoringIdentifiers.DuplicateStatement)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ExpandCompoundAssignment, "Expand compound assignment", IsEnabled(RefactoringIdentifiers.ExpandCompoundAssignment)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ExpandCoalesceExpression, "Expand coalesce expression", IsEnabled(RefactoringIdentifiers.ExpandCoalesceExpression)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ExpandEventDeclaration, "Expand event declaration", IsEnabled(RefactoringIdentifiers.ExpandEventDeclaration)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ConvertExpressionBodyToBlockBody, "Convert expression-body to block body", IsEnabled(RefactoringIdentifiers.ConvertExpressionBodyToBlockBody)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ExpandInitializer, "Expand initializer", IsEnabled(RefactoringIdentifiers.ExpandInitializer)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ConvertLambdaExpressionBodyToBlockBody, "Convert lambda expression body to block body", IsEnabled(RefactoringIdentifiers.ConvertLambdaExpressionBodyToBlockBody)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ConvertAutoPropertyToFullPropertyWithoutBackingField, "Convert auto-property to full property (without backing field)", IsEnabled(RefactoringIdentifiers.ConvertAutoPropertyToFullPropertyWithoutBackingField)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ConvertAutoPropertyToFullProperty, "Convert auto-property to full property", IsEnabled(RefactoringIdentifiers.ConvertAutoPropertyToFullProperty)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ExtractExpressionFromCondition, "Extract expression from condition", IsEnabled(RefactoringIdentifiers.ExtractExpressionFromCondition)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.RemoveContainingStatement, "Remove containing statement", IsEnabled(RefactoringIdentifiers.RemoveContainingStatement)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ExtractTypeDeclarationToNewFile, "Extract type declaration to a new file", IsEnabled(RefactoringIdentifiers.ExtractTypeDeclarationToNewFile)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.WrapArguments, "Wrap arguments", IsEnabled(RefactoringIdentifiers.WrapArguments)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.WrapBinaryExpression, "Wrap binary expression", IsEnabled(RefactoringIdentifiers.WrapBinaryExpression)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.WrapConditionalExpression, "Wrap conditional expression", IsEnabled(RefactoringIdentifiers.WrapConditionalExpression)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.WrapCallChain, "Wrap call chain", IsEnabled(RefactoringIdentifiers.WrapCallChain)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.WrapInitializerExpressions, "Wrap initializer expressions", IsEnabled(RefactoringIdentifiers.WrapInitializerExpressions)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.WrapParameters, "Wrap parameters", IsEnabled(RefactoringIdentifiers.WrapParameters)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.GenerateBaseConstructors, "Generate base constructors", IsEnabled(RefactoringIdentifiers.GenerateBaseConstructors)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.GenerateCombinedEnumMember, "Generate combined enum member", IsEnabled(RefactoringIdentifiers.GenerateCombinedEnumMember)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.GenerateEnumMember, "Generate enum member", IsEnabled(RefactoringIdentifiers.GenerateEnumMember)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.GenerateEnumValues, "Generate enum values", IsEnabled(RefactoringIdentifiers.GenerateEnumValues)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.GenerateEventInvokingMethod, "Generate event invoking method", IsEnabled(RefactoringIdentifiers.GenerateEventInvokingMethod)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.AddMissingCasesToSwitchStatement, "Add missing cases to switch statement", IsEnabled(RefactoringIdentifiers.AddMissingCasesToSwitchStatement)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.InitializeLocalVariableWithDefaultValue, "Initialize local variable with default value", IsEnabled(RefactoringIdentifiers.InitializeLocalVariableWithDefaultValue)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.InlineAliasExpression, "Inline alias expression", IsEnabled(RefactoringIdentifiers.InlineAliasExpression)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.InlineMethod, "Inline method", IsEnabled(RefactoringIdentifiers.InlineMethod)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.InsertStringInterpolation, "Insert string interpolation", IsEnabled(RefactoringIdentifiers.InsertStringInterpolation)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.IntroduceAndInitializeField, "Introduce and initialize field", IsEnabled(RefactoringIdentifiers.IntroduceAndInitializeField)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.IntroduceAndInitializeProperty, "Introduce and initialize property", IsEnabled(RefactoringIdentifiers.IntroduceAndInitializeProperty)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.IntroduceConstructor, "Introduce constructor", IsEnabled(RefactoringIdentifiers.IntroduceConstructor)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.IntroduceFieldToLockOn, "Introduce field to lock on", IsEnabled(RefactoringIdentifiers.IntroduceFieldToLockOn)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.IntroduceLocalVariable, "Introduce local variable", IsEnabled(RefactoringIdentifiers.IntroduceLocalVariable)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.MakeMemberAbstract, "Make member abstract", IsEnabled(RefactoringIdentifiers.MakeMemberAbstract)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.MakeMemberVirtual, "Make member virtual", IsEnabled(RefactoringIdentifiers.MakeMemberVirtual)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.RemoveUnnecessaryAssignment, "Remove unnecessary assignment", IsEnabled(RefactoringIdentifiers.RemoveUnnecessaryAssignment)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.MergeAttributes, "Merge attributes", IsEnabled(RefactoringIdentifiers.MergeAttributes)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.MergeIfStatements, "Merge 'if' statements", IsEnabled(RefactoringIdentifiers.MergeIfStatements)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.MergeLocalDeclarations, "Merge local declarations", IsEnabled(RefactoringIdentifiers.MergeLocalDeclarations)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.JoinStringExpressions, "Join string expressions", IsEnabled(RefactoringIdentifiers.JoinStringExpressions)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.InvertBinaryExpression, "Invert binary expression", IsEnabled(RefactoringIdentifiers.InvertBinaryExpression)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.InvertBooleanLiteral, "Invert boolean literal", IsEnabled(RefactoringIdentifiers.InvertBooleanLiteral)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.InvertIsExpression, "Invert is expression", IsEnabled(RefactoringIdentifiers.InvertIsExpression)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.InvertOperator, "Invert operator", IsEnabled(RefactoringIdentifiers.InvertOperator)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.NotifyWhenPropertyChanges, "Notify when property changes", IsEnabled(RefactoringIdentifiers.NotifyWhenPropertyChanges)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ParenthesizeExpression, "Parenthesize expression", IsEnabled(RefactoringIdentifiers.ParenthesizeExpression)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.PromoteLocalVariableToParameter, "Promote local variable to parameter", IsEnabled(RefactoringIdentifiers.PromoteLocalVariableToParameter)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.RemoveAllComments, "Remove all comments", IsEnabled(RefactoringIdentifiers.RemoveAllComments)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.RemoveAllCommentsExceptDocumentationComments, "Remove all comments (except documentation comments)", IsEnabled(RefactoringIdentifiers.RemoveAllCommentsExceptDocumentationComments)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.RemoveAllDocumentationComments, "Remove all documentation comments", IsEnabled(RefactoringIdentifiers.RemoveAllDocumentationComments)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.RemoveAllMemberDeclarations, "Remove all member declarations", IsEnabled(RefactoringIdentifiers.RemoveAllMemberDeclarations)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.RemoveAllPreprocessorDirectives, "Remove all preprocessor directives", IsEnabled(RefactoringIdentifiers.RemoveAllPreprocessorDirectives)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.RemoveAllRegionDirectives, "Remove all region directives", IsEnabled(RefactoringIdentifiers.RemoveAllRegionDirectives)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.RemoveAllStatements, "Remove all statements", IsEnabled(RefactoringIdentifiers.RemoveAllStatements)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.RemoveAllSwitchSections, "Remove all switch sections", IsEnabled(RefactoringIdentifiers.RemoveAllSwitchSections)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.RemoveBraces, "Remove braces", IsEnabled(RefactoringIdentifiers.RemoveBraces)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.RemoveBracesFromIfElse, "Remove braces from if-else", IsEnabled(RefactoringIdentifiers.RemoveBracesFromIfElse)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.RemoveBracesFromSwitchSection, "Remove braces from switch section", IsEnabled(RefactoringIdentifiers.RemoveBracesFromSwitchSection)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.RemoveBracesFromSwitchSections, "Remove braces from switch sections", IsEnabled(RefactoringIdentifiers.RemoveBracesFromSwitchSections)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.RemoveComment, "Remove comment", IsEnabled(RefactoringIdentifiers.RemoveComment)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.RemoveConditionFromLastElse, "Remove condition from last else clause", IsEnabled(RefactoringIdentifiers.RemoveConditionFromLastElse)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.RemovePreprocessorDirective, "Remove preprocessor directive", IsEnabled(RefactoringIdentifiers.RemovePreprocessorDirective)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.RemoveEmptyLines, "Remove empty lines", IsEnabled(RefactoringIdentifiers.RemoveEmptyLines)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.RemoveInterpolation, "Remove interpolation", IsEnabled(RefactoringIdentifiers.RemoveInterpolation)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.RemoveMemberDeclaration, "Remove member declaration", IsEnabled(RefactoringIdentifiers.RemoveMemberDeclaration)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.RemoveMemberDeclarations, "Remove member declarations above/below", IsEnabled(RefactoringIdentifiers.RemoveMemberDeclarations)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.RemoveParameterNameFromArgument, "Remove parameter name from argument", IsEnabled(RefactoringIdentifiers.RemoveParameterNameFromArgument)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.RemoveParentheses, "Remove parentheses", IsEnabled(RefactoringIdentifiers.RemoveParentheses)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.RemovePropertyInitializer, "Remove property initializer", IsEnabled(RefactoringIdentifiers.RemovePropertyInitializer)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.RemoveRegion, "Remove region", IsEnabled(RefactoringIdentifiers.RemoveRegion)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.RemoveStatement, "Remove statement", IsEnabled(RefactoringIdentifiers.RemoveStatement)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.MergeSwitchSections, "Merge switch sections", IsEnabled(RefactoringIdentifiers.MergeSwitchSections)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.SyncPropertyNameAndBackingFieldName, "Synchronize property name and backing field name", IsEnabled(RefactoringIdentifiers.SyncPropertyNameAndBackingFieldName)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.RenameIdentifierAccordingToTypeName, "Rename identifier according to type name", IsEnabled(RefactoringIdentifiers.RenameIdentifierAccordingToTypeName)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.RenameMethodAccordingToTypeName, "Rename method according to type name", IsEnabled(RefactoringIdentifiers.RenameMethodAccordingToTypeName)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.RenameParameterAccordingToTypeName, "Rename parameter according to its type name", IsEnabled(RefactoringIdentifiers.RenameParameterAccordingToTypeName)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.RenamePropertyAccordingToTypeName, "Rename property according to type name", IsEnabled(RefactoringIdentifiers.RenamePropertyAccordingToTypeName)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.InvertLinqMethodCall, "Invert LINQ method call", IsEnabled(RefactoringIdentifiers.InvertLinqMethodCall)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ReplaceAsExpressionWithExplicitCast, "Replace 'as' expression with explicit cast", IsEnabled(RefactoringIdentifiers.ReplaceAsExpressionWithExplicitCast)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ReplaceExplicitCastWithAsExpression, "Replace explicit cast expression 'as' expression", IsEnabled(RefactoringIdentifiers.ReplaceExplicitCastWithAsExpression)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ReplaceConditionalExpressionWithTrueOrFalseBranch, "Replace conditional expression with true/false branch", IsEnabled(RefactoringIdentifiers.ReplaceConditionalExpressionWithTrueOrFalseBranch)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ConvertConditionalExpressionToIfElse, "Convert ?: to if-else", IsEnabled(RefactoringIdentifiers.ConvertConditionalExpressionToIfElse)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.UseReadOnlyFieldInsteadOfConstant, "Use read-only field instead of constant", IsEnabled(RefactoringIdentifiers.UseReadOnlyFieldInsteadOfConstant)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ConvertDoToWhile, "Convert 'do' to 'while'", IsEnabled(RefactoringIdentifiers.ConvertDoToWhile)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ReplaceEqualityOperatorWithStringEquals, "Replace equality operator with string.Equals", IsEnabled(RefactoringIdentifiers.ReplaceEqualityOperatorWithStringEquals)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ReplaceEqualityOperatorWithStringIsNullOrEmpty, "Replace equality operator with string.IsNullOrEmpty", IsEnabled(RefactoringIdentifiers.ReplaceEqualityOperatorWithStringIsNullOrEmpty)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ReplaceEqualityOperatorWithStringIsNullOrWhiteSpace, "Replace equality operator with string.IsNullOrWhiteSpace", IsEnabled(RefactoringIdentifiers.ReplaceEqualityOperatorWithStringIsNullOrWhiteSpace)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.InlineConstantValue, "Inline constant value", IsEnabled(RefactoringIdentifiers.InlineConstantValue)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.UseConstantInsteadOfReadOnlyField, "Use constant instead of read-only field", IsEnabled(RefactoringIdentifiers.UseConstantInsteadOfReadOnlyField)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ConvertForEachToFor, "Convert 'foreach' to 'for'", IsEnabled(RefactoringIdentifiers.ConvertForEachToFor)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ConvertForToForEach, "Convert 'for' to 'foreach'", IsEnabled(RefactoringIdentifiers.ConvertForToForEach)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ConvertForToWhile, "Convert 'for' to 'while'", IsEnabled(RefactoringIdentifiers.ConvertForToWhile)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ConvertHexadecimalLiteralToDecimalLiteral, "Convert hexadecimal literal to decimal literal", IsEnabled(RefactoringIdentifiers.ConvertHexadecimalLiteralToDecimalLiteral)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ConvertIfToSwitch, "Convert 'if' to 'switch'", IsEnabled(RefactoringIdentifiers.ConvertIfToSwitch)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.InvertPrefixOrPostfixUnaryOperator, "Invert prefix/postfix unary operator", IsEnabled(RefactoringIdentifiers.InvertPrefixOrPostfixUnaryOperator)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ReplaceInterpolatedStringWithInterpolationExpression, "Replace interpolated string with interpolation expression", IsEnabled(RefactoringIdentifiers.ReplaceInterpolatedStringWithInterpolationExpression)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ConvertInterpolatedStringToStringLiteral, "Convert interpolated string to string literal", IsEnabled(RefactoringIdentifiers.ConvertInterpolatedStringToStringLiteral)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ConvertMethodGroupToLambda, "Convert method group to lambda", IsEnabled(RefactoringIdentifiers.ConvertMethodGroupToLambda)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ReplaceMethodWithProperty, "Replace method with property", IsEnabled(RefactoringIdentifiers.ReplaceMethodWithProperty)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ConvertNullLiteralToDefaultExpression, "Convert null literal to default expression", IsEnabled(RefactoringIdentifiers.ConvertNullLiteralToDefaultExpression)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ReplacePrefixOperatorWithPostfixOperator, "Replace prefix operator to postfix operator", IsEnabled(RefactoringIdentifiers.ReplacePrefixOperatorWithPostfixOperator)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ReplacePropertyWithMethod, "Replace property with method", IsEnabled(RefactoringIdentifiers.ReplacePropertyWithMethod)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ConvertRegularStringLiteralToVerbatimStringLiteral, "Convert regular string literal to verbatim string literal", IsEnabled(RefactoringIdentifiers.ConvertRegularStringLiteralToVerbatimStringLiteral)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ConvertReturnToIf, "Convert '(yield) return' to 'if'", IsEnabled(RefactoringIdentifiers.ConvertReturnToIf)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.CallIndexOfInsteadOfContains, "Call string.IndexOf instead of string.Contains", IsEnabled(RefactoringIdentifiers.CallIndexOfInsteadOfContains)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ConvertStringFormatToInterpolatedString, "Convert 'string.Format' to interpolated string", IsEnabled(RefactoringIdentifiers.ConvertStringFormatToInterpolatedString)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ConvertSwitchToIf, "Convert 'switch' to 'if'", IsEnabled(RefactoringIdentifiers.ConvertSwitchToIf)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ConvertVerbatimStringLiteralToRegularStringLiteral, "Convert verbatim string literal to regular string literal", IsEnabled(RefactoringIdentifiers.ConvertVerbatimStringLiteralToRegularStringLiteral)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ConvertVerbatimStringLiteralToRegularStringLiterals, "Convert verbatim string literal to regular string literals", IsEnabled(RefactoringIdentifiers.ConvertVerbatimStringLiteralToRegularStringLiterals)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ConvertWhileToDo, "Convert 'while' statement to 'do' statement", IsEnabled(RefactoringIdentifiers.ConvertWhileToDo)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ConvertWhileToFor, "Convert 'while' statement to 'for' statement", IsEnabled(RefactoringIdentifiers.ConvertWhileToFor)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ReverseForStatement, "Reverse 'for' statement", IsEnabled(RefactoringIdentifiers.ReverseForStatement)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.SimplifyIf, "Simplify if", IsEnabled(RefactoringIdentifiers.SimplifyIf)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ConvertLambdaBlockBodyToExpressionBody, "Convert lambda block body to expression body", IsEnabled(RefactoringIdentifiers.ConvertLambdaBlockBodyToExpressionBody)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.SortMemberDeclarations, "Sort member declarations", IsEnabled(RefactoringIdentifiers.SortMemberDeclarations)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.SplitAttributes, "Split attributes", IsEnabled(RefactoringIdentifiers.SplitAttributes)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.SplitSwitchLabels, "Split switch labels", IsEnabled(RefactoringIdentifiers.SplitSwitchLabels)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.SplitVariableDeclaration, "Split variable declaration", IsEnabled(RefactoringIdentifiers.SplitVariableDeclaration)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.SwapBinaryOperands, "Swap binary operands", IsEnabled(RefactoringIdentifiers.SwapBinaryOperands)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.InvertConditionalExpression, "Invert conditional expression", IsEnabled(RefactoringIdentifiers.InvertConditionalExpression)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.SwapMemberDeclarations, "Swap member declarations", IsEnabled(RefactoringIdentifiers.SwapMemberDeclarations)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.InvertIfElse, "Invert if-else", IsEnabled(RefactoringIdentifiers.InvertIfElse)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.UncommentSingleLineComment, "Uncomment single-line comment", IsEnabled(RefactoringIdentifiers.UncommentSingleLineComment)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ConvertHasFlagCallToBitwiseOperation, "Convert 'HasFlag' call to bitwise operation", IsEnabled(RefactoringIdentifiers.ConvertHasFlagCallToBitwiseOperation)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.UseCoalesceExpressionInsteadOfIf, "Use coalesce expression instead of if", IsEnabled(RefactoringIdentifiers.UseCoalesceExpressionInsteadOfIf)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ConvertIfToConditionalExpression, "Convert 'if' to ?:", IsEnabled(RefactoringIdentifiers.ConvertIfToConditionalExpression)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.UseElementAccessInsteadOfLinqMethod, "Use element access instead of LINQ method", IsEnabled(RefactoringIdentifiers.UseElementAccessInsteadOfLinqMethod)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ConvertBlockBodyToExpressionBody, "Convert block body to expression-body", IsEnabled(RefactoringIdentifiers.ConvertBlockBodyToExpressionBody)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.UseLambdaInsteadOfAnonymousMethod, "Use lambda instead of anonymous method", IsEnabled(RefactoringIdentifiers.UseLambdaInsteadOfAnonymousMethod)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.UseStringEmptyInsteadOfEmptyStringLiteral, "Convert \"\" to string.Empty", IsEnabled(RefactoringIdentifiers.UseStringEmptyInsteadOfEmptyStringLiteral)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.WrapStatementsInCondition, "Wrap statements in condition", IsEnabled(RefactoringIdentifiers.WrapStatementsInCondition)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.WrapLinesInPreprocessorDirective, "Wrap lines in preprocessor directive", IsEnabled(RefactoringIdentifiers.WrapLinesInPreprocessorDirective)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.WrapLinesInRegion, "Wrap lines in #region directive", IsEnabled(RefactoringIdentifiers.WrapLinesInRegion)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.WrapLinesInTryCatch, "Wrap lines in try-catch", IsEnabled(RefactoringIdentifiers.WrapLinesInTryCatch)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.WrapStatementsInUsingStatement, "Wrap statements in 'using' statement", IsEnabled(RefactoringIdentifiers.WrapStatementsInUsingStatement)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.AddGenericParameterToDeclaration, "Add generic parameter to a declaration", IsEnabled(RefactoringIdentifiers.AddGenericParameterToDeclaration)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ImplementIEquatableOfT, "Implement IEquatable<T>", IsEnabled(RefactoringIdentifiers.ImplementIEquatableOfT)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.InlineUsingStaticDirective, "Inline using static directive", IsEnabled(RefactoringIdentifiers.InlineUsingStaticDirective)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.InlineConstantDeclaration, "Inline constant declaration", IsEnabled(RefactoringIdentifiers.InlineConstantDeclaration)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.UseStringBuilderInsteadOfConcatenation, "Use StringBuilder instead of concatenation", IsEnabled(RefactoringIdentifiers.UseStringBuilderInsteadOfConcatenation)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.UseListInsteadOfYield, "Use List<T> instead of yield", IsEnabled(RefactoringIdentifiers.UseListInsteadOfYield)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.SplitIf, "Split if", IsEnabled(RefactoringIdentifiers.SplitIf)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.RemoveInstantiationOfLocalVariable, "Remove instantiation of a local variable", IsEnabled(RefactoringIdentifiers.RemoveInstantiationOfLocalVariable)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ChangeAccessibility, "Change accessibility", IsEnabled(RefactoringIdentifiers.ChangeAccessibility)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.WrapConstraintClauses, "Wrap constraint clauses", IsEnabled(RefactoringIdentifiers.WrapConstraintClauses)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ConvertForEachToForAndReverseLoop, "Convert 'foreach' to 'for' and reverse loop", IsEnabled(RefactoringIdentifiers.ConvertForEachToForAndReverseLoop)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.InvertIf, "Invert if", IsEnabled(RefactoringIdentifiers.InvertIf)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.SplitIfElse, "Split if-else", IsEnabled(RefactoringIdentifiers.SplitIfElse)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.UseIndexInitializer, "Use index initializer", IsEnabled(RefactoringIdentifiers.UseIndexInitializer)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ConvertCommentToDocumentationComment, "Convert comment to documentation comment", IsEnabled(RefactoringIdentifiers.ConvertCommentToDocumentationComment)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ConvertInterpolatedStringToConcatenation, "Convert interpolated string to concatenation", IsEnabled(RefactoringIdentifiers.ConvertInterpolatedStringToConcatenation)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.AddMemberToInterface, "Add member to interface", IsEnabled(RefactoringIdentifiers.AddMemberToInterface)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.MergeIfWithParentIf, "Merge if with parent if", IsEnabled(RefactoringIdentifiers.MergeIfWithParentIf)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.InitializeFieldFromConstructor, "Initialize field from constructor", IsEnabled(RefactoringIdentifiers.InitializeFieldFromConstructor)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.InlineProperty, "Inline property", IsEnabled(RefactoringIdentifiers.InlineProperty)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.RemoveEnumMemberValue, "Remove enum member value(s)", IsEnabled(RefactoringIdentifiers.RemoveEnumMemberValue)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.UncommentMultiLineComment, "Uncomment multi-line comment", IsEnabled(RefactoringIdentifiers.UncommentMultiLineComment)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ConvertInterpolatedStringToStringFormat, "Convert interpolated string to 'string.Format'", IsEnabled(RefactoringIdentifiers.ConvertInterpolatedStringToStringFormat)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.MoveUnsafeContextToContainingDeclaration, "Move unsafe context to containing declaration", IsEnabled(RefactoringIdentifiers.MoveUnsafeContextToContainingDeclaration)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ExtractEventHandlerMethod, "Extract event handler method", IsEnabled(RefactoringIdentifiers.ExtractEventHandlerMethod)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.GeneratePropertyForDebuggerDisplayAttribute, "Generate property for DebuggerDisplay attribute", IsEnabled(RefactoringIdentifiers.GeneratePropertyForDebuggerDisplayAttribute)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.AddEmptyLineBetweenDeclarations, "Add empty line between declarations", IsEnabled(RefactoringIdentifiers.AddEmptyLineBetweenDeclarations)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.UseEnumeratorExplicitly, "Use enumerator explicitly", IsEnabled(RefactoringIdentifiers.UseEnumeratorExplicitly)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.SortCaseLabels, "Sort case labels", IsEnabled(RefactoringIdentifiers.SortCaseLabels)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.AddTagToDocumentationComment, "Add tag to documentation comment", IsEnabled(RefactoringIdentifiers.AddTagToDocumentationComment)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.RemoveAsyncAwait, "Remove async/await", IsEnabled(RefactoringIdentifiers.RemoveAsyncAwait)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ImplementCustomEnumerator, "Implement custom enumerator", IsEnabled(RefactoringIdentifiers.ImplementCustomEnumerator)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ConvertStatementsToIfElse, "Convert statements to if-else", IsEnabled(RefactoringIdentifiers.ConvertStatementsToIfElse)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.DuplicateSwitchSection, "Duplicate switch section", IsEnabled(RefactoringIdentifiers.DuplicateSwitchSection)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.AddParameterToInterfaceMember, "Add parameter to interface member", IsEnabled(RefactoringIdentifiers.AddParameterToInterfaceMember)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ConvertSwitchExpressionToSwitchStatement, "Convert 'switch' expression to 'switch' statement", IsEnabled(RefactoringIdentifiers.ConvertSwitchExpressionToSwitchStatement)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.ExpandPositionalConstructor, "Expand positional constructor", IsEnabled(RefactoringIdentifiers.ExpandPositionalConstructor)));
            refactorings.Add(new BaseModel(RefactoringIdentifiers.AddAllPropertiesToInitializer, "Add all properties to initializer", IsEnabled(RefactoringIdentifiers.AddAllPropertiesToInitializer)));
        }
    }
}