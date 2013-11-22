﻿using System;
using ENode.Eventing;

namespace NoteSample.DomainEvents
{
    [Serializable]
    public class NoteCreated : DomainEvent<Guid>, ISourcingEvent
    {
        public string Title { get; private set; }
        public DateTime CreatedTime { get; private set; }
        public DateTime UpdatedTime { get; private set; }

        public NoteCreated(Guid noteId, string title, DateTime createdTime, DateTime updatedTime) : base(noteId)
        {
            Title = title;
            CreatedTime = createdTime;
            UpdatedTime = updatedTime;
        }
    }
}