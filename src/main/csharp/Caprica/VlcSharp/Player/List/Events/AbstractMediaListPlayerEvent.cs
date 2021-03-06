/*
 * This file is part of VLCSHARP.
 *
 * VLCSHARP is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * VLCSHARP is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with VLCSHARP.  If not, see <http://www.gnu.org/licenses/>.
 * 
 * Copyright 2012 Caprica Software Limited.
 */

using System;

namespace Caprica.VlcSharp.Player.List.Events {

    /**
     * Base implementation for media list player events.
     * <p>
     * Every instance of an event refers to an associated media list player.
     */
    abstract class AbstractMediaListPlayerEvent : MediaListPlayerEvent {
    
        /**
         * The media list player the event relates to.
         */
        protected readonly MediaListPlayer mediaListPlayer;
    
        /**
         * Create a media player event.
         * 
         * @param mediaListPlayer media player that the event relates to
         */
        protected AbstractMediaListPlayerEvent(MediaListPlayer mediaListPlayer) {
            this.mediaListPlayer = mediaListPlayer;
        }
    
        public abstract void Notify(MediaListPlayerEventListener listener);		
    }
}