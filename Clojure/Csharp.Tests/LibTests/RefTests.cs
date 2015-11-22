/**
 *   Copyright (c) Rich Hickey. All rights reserved.
 *   The use and distribution terms for this software are covered by the
 *   Eclipse Public License 1.0 (http://opensource.org/licenses/eclipse-1.0.php)
 *   which can be found in the file epl-v10.html at the root of this distribution.
 *   By using this software in any fashion, you are agreeing to be bound by
 * 	 the terms of this license.
 *   You must not remove this notice, or any other, from this software.
 **/

/**
 *   Author: David Miller
 **/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;

using clojure.lang;

namespace Clojure.Tests.LibTests
{
    // TODO: Add tests for Ref

    [TestFixture]
    public class RefTests
    {
        // Equality and comparison tests

        [Test]
        public void RefCompareToNullIs1()
        {
            Ref r = new Ref(null);
            Assert.AreEqual(1, r.CompareTo(null));
        }

        [Test]
        public void RefCompareToSelfIs0()
        {
            Ref r = new Ref(null);
            Assert.AreEqual(0, r.CompareTo(r));
        }

        [Test]
        public void OlderRefCompareToNewerRef()
        {
            Ref older = new Ref(null);
            Ref newer = new Ref(null);
            Assert.IsTrue(older.CompareTo(newer) < 0);
            Assert.IsTrue(newer.CompareTo(older) > 0);
        }

        [Test]
        public void OlderRefNotEqualsNewerRef()
        {
            Ref older = new Ref(null);
            Ref newer = new Ref(null);
            Assert.IsFalse(older.Equals(newer));
            Assert.IsFalse(older == newer);
            Assert.IsTrue(older != newer);
        }

        [Test]
        public void NewerRefNotEqualsOlderRef()
        {
            Ref older = new Ref(null);
            Ref newer = new Ref(null);
            Assert.IsFalse(newer.Equals(older));
            Assert.IsFalse(newer == older);
            Assert.IsTrue(newer != older);
        }

        [Test]
        public void OlderRefGreaterThanNewerRef()
        {
            Ref older = new Ref(null);
            Ref newer = new Ref(null);
            Assert.IsFalse(older > newer);
        }

        [Test]
        public void NewerRefLessThanOlderRef()
        {
            Ref older = new Ref(null);
            Ref newer = new Ref(null);
            Assert.IsFalse(newer < older);
        }

        [Test]
        public void RefGreaterThanNull()
        {
            Ref r = new Ref(null);
            Ref other = null;
            Assert.IsTrue(r > other);
        }

        [Test]
        public void RefLessThanNull()
        {
            Ref r = new Ref(null);
            Ref other = null;
            Assert.IsFalse(r < other);
        }

        [Test]
        public void RefEqualsNull()
        {
            Ref r = new Ref(null);
            Ref other = null;
            Assert.IsFalse(r.Equals(other));
            Assert.IsFalse(r == other);
            Assert.IsTrue(r != other);
        }

        [Test]
        public void NullEqualsRef()
        {
            Ref r = null;
            Ref other = new Ref(null);
            Assert.IsFalse(r == other);
            Assert.IsTrue(r != other);
        }

        [Test]
        public void RefEqualsSelf()
        {
            #pragma warning disable 1718
            Ref r = new Ref(null);
            Assert.IsTrue(r.Equals(r));
            Assert.IsTrue(r == r);
            Assert.IsFalse(r != r);
            #pragma warning restore 1718
        }
    }
}
