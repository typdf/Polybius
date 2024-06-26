﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AUOffsetManager;

namespace AmongUsCapture
{
    public class PlayerVoteArea
    {
        public byte[] byteArray;
        public byte Id_;
        public bool didReport;
        public sbyte votedFor;
        public bool set(IntPtr _objectPtr, ProcessMemory MemInstance, GameOffsets CurrentOffsets)
        {
            VoteAreaOffsets offsets = CurrentOffsets.VoteAreaOffsets;
            byte[] byteArray = ProcessMemory.getInstance().ReadByteArray(_objectPtr, offsets.votedFor + 1);
            if (byteArray != null)
            {
                Id_ = (byte)byteArray[offsets._Id];
                didReport = BitConverter.ToBoolean(byteArray, offsets.didReport);
                votedFor = (sbyte)byteArray[offsets.votedFor];
                return true;
            }
            else
            {
                return false;
            }


        }

    }
    /*
    public interface PlayerVoteArea
    {
        public IntPtr m_CachedPtr { get; }
        public sbyte Id_ { get; }
        public IntPtr Buttons { get; }
        public IntPtr PlayerIcon { get; }
        public IntPtr Background { get; }
        public IntPtr Flag { get; }
        public IntPtr Megaphone { get; }
        public IntPtr Overlay { get; }
        public IntPtr NameText { get; }
        public bool isDead { get; }
        public bool didVote { get; }
        public bool didReport { get; }
        public sbyte votedFor { get; }
        public bool voteComplete { get; }
        public bool resultsShowing { get; }

    }
    static partial class Struct_2020_12_9s
    {
        
        //OOCJALPKPEP in v2020.12.9s
        [StructLayout(LayoutKind.Explicit)]
        public struct v_MeetingHud
        {
            [FieldOffset(0x08)] public IntPtr m_CachedPtr;
            [FieldOffset(0x0C)] public uint SpawnId;
            [FieldOffset(0x10)] public uint NetId;
            [FieldOffset(0x14)] public uint DirtyBits;
            [FieldOffset(0x18)] public uint SpawnFlags;
            [FieldOffset(0x19)] public uint sendMode;
            [FieldOffset(0x1C)] public uint OwnerId;
            [FieldOffset(0x20)] public byte NOGGNBJBALN;
            [FieldOffset(0x24)] public IntPtr ButtonParent;
            [FieldOffset(0x28)] public IntPtr TitleText;
            [FieldOffset(0x2C)] public uint VoteOrigin;
            [FieldOffset(0x38)] public uint VoteButtonOffsets;
            [FieldOffset(0x44)] public uint FGJMDFDIKEK;
            [FieldOffset(0x50)] public uint IOHLPLMJHIB;
            [FieldOffset(0x5C)] public IntPtr SkipVoteButton;
            [FieldOffset(0x60)] public IntPtr PlayerVoteAreaList;
            [FieldOffset(0x64)] public IntPtr PlayerButtonPrefab;
            [FieldOffset(0x68)] public IntPtr PlayerVotePrefab;
            [FieldOffset(0x6C)] public IntPtr CrackedGlass;
            [FieldOffset(0x70)] public IntPtr Glass;
            [FieldOffset(0x74)] public IntPtr ProceedButton;
            [FieldOffset(0x78)] public IntPtr VoteSound;
            [FieldOffset(0x7C)] public IntPtr VoteLockinSound;
            [FieldOffset(0x80)] public IntPtr VoteEndingSound;
            [FieldOffset(0x84)] public uint DCCFKHIPIOF;
            [FieldOffset(0x88)] public IntPtr SkippedVoting;
            [FieldOffset(0x8C)] public IntPtr HostIcon;
            [FieldOffset(0x90)] public IntPtr KillBackground;
            [FieldOffset(0x94)] public IntPtr LCJLLGKMINO;
            [FieldOffset(0x98)] public byte GEJDOOANNJD;
            [FieldOffset(0x9C)] public IntPtr TimerText;
            [FieldOffset(0xA0)] public float discussionTimer;
            [FieldOffset(0xA4)] public byte EANIGGGNMAF;
            [FieldOffset(0xA5)] public byte PIKBAKKGJEA;
            [FieldOffset(0xA8)] public float EKGJAHLFJFP;
            [FieldOffset(0xAC)] public uint NHPLGFPGAJL;
        }

        //HDJGDMFCHDN in v2020.12.9s
        [StructLayout(LayoutKind.Explicit)]
        public struct v_PlayerVoteArea : PlayerVoteArea
        {
            [FieldOffset(0x08)] public IntPtr m_CachedPtr;
            [FieldOffset(0x10)] public sbyte Id_;
            [FieldOffset(0x14)] public IntPtr Buttons;
            [FieldOffset(0x18)] public IntPtr PlayerIcon;
            [FieldOffset(0x1C)] public IntPtr Background;
            [FieldOffset(0x20)] public IntPtr Flag;
            [FieldOffset(0x24)] public IntPtr Megaphone;
            [FieldOffset(0x28)] public IntPtr Overlay;
            [FieldOffset(0x2C)] public IntPtr NameText;
            [FieldOffset(0x30)] public bool isDead;
            [FieldOffset(0x31)] public bool didVote;
            [FieldOffset(0x32)] public bool didReport;
            [FieldOffset(0x33)] public sbyte votedFor;
            [FieldOffset(0x34)] public bool voteComplete;
            [FieldOffset(0x35)] public bool resultsShowing;


            IntPtr PlayerVoteArea.m_CachedPtr => m_CachedPtr;
            sbyte PlayerVoteArea.Id_ => Id_;
            IntPtr PlayerVoteArea.Buttons => Buttons;
            IntPtr PlayerVoteArea.PlayerIcon => PlayerIcon;
            IntPtr PlayerVoteArea.Background => Background;
            IntPtr PlayerVoteArea.Flag => Flag;
            IntPtr PlayerVoteArea.Megaphone => Megaphone;
            IntPtr PlayerVoteArea.Overlay => Overlay;
            IntPtr PlayerVoteArea.NameText => NameText;
            bool PlayerVoteArea.isDead => isDead;
            bool PlayerVoteArea.didVote => didVote;
            bool PlayerVoteArea.didReport => didReport;
            sbyte PlayerVoteArea.votedFor => votedFor;
            bool PlayerVoteArea.voteComplete => voteComplete;
            bool PlayerVoteArea.resultsShowing => resultsShowing;

        }
    }

    static partial class Struct_2021_3_5s
    {
        [StructLayout(LayoutKind.Explicit)]
        public struct v_MeetingHud
        {
            [FieldOffset(0x08)] public IntPtr m_CachedPtr;
            [FieldOffset(0x0C)] public uint SpawnId;
            [FieldOffset(0x10)] public uint NetId;
            [FieldOffset(0x14)] public uint DirtyBits;
            [FieldOffset(0x18)] public uint SpawnFlags;
            [FieldOffset(0x19)] public uint sendMode;
            [FieldOffset(0x1C)] public uint OwnerId;
            [FieldOffset(0x20)] public byte NOGGNBJBALN;
            [FieldOffset(0x24)] public IntPtr ButtonParent;
            [FieldOffset(0x28)] public IntPtr TitleText;
            [FieldOffset(0x2C)] public uint VoteOrigin;
            [FieldOffset(0x38)] public uint VoteButtonOffsets;
            [FieldOffset(0x44)] public uint FGJMDFDIKEK;
            [FieldOffset(0x50)] public uint IOHLPLMJHIB;
            [FieldOffset(0x5C)] public IntPtr SkipVoteButton;
            [FieldOffset(0x60)] public IntPtr PlayerVoteAreaList;
            [FieldOffset(0x64)] public IntPtr PlayerButtonPrefab;
            [FieldOffset(0x68)] public IntPtr PlayerVotePrefab;
            [FieldOffset(0x6C)] public IntPtr CrackedGlass;
            [FieldOffset(0x70)] public IntPtr Glass;
            [FieldOffset(0x74)] public IntPtr ProceedButton;
            [FieldOffset(0x78)] public IntPtr VoteSound;
            [FieldOffset(0x7C)] public IntPtr VoteLockinSound;
            [FieldOffset(0x80)] public IntPtr VoteEndingSound;
            [FieldOffset(0x84)] public uint DCCFKHIPIOF;
            [FieldOffset(0x88)] public IntPtr SkippedVoting;
            [FieldOffset(0x8C)] public IntPtr HostIcon;
            [FieldOffset(0x90)] public IntPtr KillBackground;
            [FieldOffset(0x94)] public IntPtr LCJLLGKMINO;
            [FieldOffset(0x98)] public byte GEJDOOANNJD;
            [FieldOffset(0x9C)] public IntPtr TimerText;
            [FieldOffset(0xA0)] public float discussionTimer;
            [FieldOffset(0xA4)] public byte EANIGGGNMAF;
            [FieldOffset(0xA5)] public byte PIKBAKKGJEA;
            [FieldOffset(0xA8)] public float EKGJAHLFJFP;
            [FieldOffset(0xAC)] public uint NHPLGFPGAJL;
        }

        //PlayerVoteArea in v2021.3.5s
        [StructLayout(LayoutKind.Explicit)]
        public struct v_PlayerVoteArea : PlayerVoteArea
        {
            [FieldOffset(0x08)] public IntPtr m_CachedPtr;
            [FieldOffset(0x10)] public sbyte Id_;
            [FieldOffset(0x14)] public IntPtr Buttons;
            [FieldOffset(0x18)] public IntPtr ConfirmButton;
            [FieldOffset(0x1C)] public IntPtr CancelButton;
            [FieldOffset(0x20)] public IntPtr PlayerButton;
            [FieldOffset(0x24)] public IntPtr PlayerIcon;
            [FieldOffset(0x28)] public IntPtr Background;
            [FieldOffset(0x2C)] public IntPtr Flag;
            [FieldOffset(0x30)] public IntPtr Megaphone;
            [FieldOffset(0x34)] public IntPtr Overlay;
            [FieldOffset(0x38)] public IntPtr NameText;
            [FieldOffset(0x3C)] public IntPtr PlatformIcon;
            [FieldOffset(0x40)] public bool isDead;
            [FieldOffset(0x41)] public bool didVote;
            [FieldOffset(0x42)] public bool didReport;
            [FieldOffset(0x43)] public sbyte votedFor;
            [FieldOffset(0x44)] public bool voteComplete;
            [FieldOffset(0x45)] public bool resultsShowing;

            IntPtr PlayerVoteArea.m_CachedPtr => m_CachedPtr;
            sbyte PlayerVoteArea.Id_ => Id_;
            IntPtr PlayerVoteArea.Buttons => Buttons;
            IntPtr PlayerVoteArea.PlayerIcon => PlayerIcon;
            IntPtr PlayerVoteArea.Background => Background;
            IntPtr PlayerVoteArea.Flag => Flag;
            IntPtr PlayerVoteArea.Megaphone => Megaphone;
            IntPtr PlayerVoteArea.Overlay => Overlay;
            IntPtr PlayerVoteArea.NameText => NameText;
            bool PlayerVoteArea.isDead => isDead;
            bool PlayerVoteArea.didVote => didVote;
            bool PlayerVoteArea.didReport => didReport;
            sbyte PlayerVoteArea.votedFor {
                get {
                    if (votedFor == 14) return -2; // not vote
                    else if (votedFor == -2) return -1; // not vote
                    else if (votedFor == -3) return -4; //Error
                    else if (votedFor == -1) return -3; //skip
                    else return votedFor; 
                } 
            }
            bool PlayerVoteArea.voteComplete => voteComplete;
            bool PlayerVoteArea.resultsShowing => resultsShowing;
        }
    }

    static partial class Struct_2021_6_15s
    {
        [StructLayout(LayoutKind.Explicit)]
        public struct v_MeetingHud
        {
            [FieldOffset(0x08)] public IntPtr m_CachedPtr;
            [FieldOffset(0x0C)] public uint SpawnId;
            [FieldOffset(0x10)] public uint NetId;
            [FieldOffset(0x14)] public uint DirtyBits;
            [FieldOffset(0x18)] public uint SpawnFlags;
            [FieldOffset(0x19)] public uint sendMode;
            [FieldOffset(0x1C)] public uint OwnerId;
            [FieldOffset(0x20)] public byte NOGGNBJBALN;
            [FieldOffset(0x24)] public IntPtr PlayerColoredParts;
            [FieldOffset(0x28)] public IntPtr MeetingIntro;
            [FieldOffset(0x2C)] public IntPtr ButtonParent;
            [FieldOffset(0x30)] public IntPtr TitleText;
            [FieldOffset(0x34)] public uint VoteOrigin;
            [FieldOffset(0x40)] public uint VoteButtonOffsets;
            [FieldOffset(0x4C)] public IntPtr SkipVoteButton;
            [FieldOffset(0x50)] public IntPtr PlayerVoteAreaList;
            [FieldOffset(0x54)] public IntPtr PlayerButtonPrefab;
            [FieldOffset(0x58)] public IntPtr PlayerVotePrefab;
            [FieldOffset(0x5C)] public IntPtr CrackedGlass;
            [FieldOffset(0x60)] public IntPtr Glass;
            [FieldOffset(0x64)] public IntPtr ProceedButton;
            [FieldOffset(0x68)] public IntPtr VoteSound;
            [FieldOffset(0x6C)] public IntPtr VoteLockinSound;
            [FieldOffset(0x70)] public IntPtr VoteEndingSound;
            [FieldOffset(0x74)] public IntPtr state;
            [FieldOffset(0x78)] public IntPtr SkippedVoting;
            [FieldOffset(0x7C)] public IntPtr HostIcon;
            [FieldOffset(0x80)] public IntPtr exiledPlayer;
            [FieldOffset(0x84)] public bool wasTie;
            [FieldOffset(0x88)] public IntPtr TimerText;
            [FieldOffset(0x8C)] public float discussionTimer;
            [FieldOffset(0x98)] public int lastSecond;
        }

        //PlayerVoteArea in v2021.6.15s
        [StructLayout(LayoutKind.Explicit)]
        public struct v_PlayerVoteArea : PlayerVoteArea
        {
            [FieldOffset(0x08)] public IntPtr m_CachedPtr;
            [FieldOffset(0x10)] public sbyte Id_;
            [FieldOffset(0x14)] public IntPtr Buttons;
            [FieldOffset(0x18)] public IntPtr ConfirmButton;
            [FieldOffset(0x1C)] public IntPtr CancelButton;
            [FieldOffset(0x20)] public IntPtr PlayerButton;
            [FieldOffset(0x24)] public IntPtr PlayerIcon;
            [FieldOffset(0x28)] public IntPtr Background;
            [FieldOffset(0x2C)] public IntPtr Flag;
            [FieldOffset(0x30)] public IntPtr Megaphone;
            [FieldOffset(0x34)] public IntPtr Overlay;
            [FieldOffset(0x38)] public IntPtr XMark;
            [FieldOffset(0x3C)] public IntPtr NameText;
            [FieldOffset(0x40)] public IntPtr PlatformIcon;
            [FieldOffset(0x45)] public bool AnimateButtonFromLeft;
            [FieldOffset(0x45)] public bool isDead;
            [FieldOffset(0x46)] public bool didReport;
            [FieldOffset(0x47)] public sbyte votedFor;
            [FieldOffset(0x48)] public bool voteComplete;
            [FieldOffset(0x49)] public bool resultsShowing;

            IntPtr PlayerVoteArea.m_CachedPtr => m_CachedPtr;
            sbyte PlayerVoteArea.Id_ => Id_;
            IntPtr PlayerVoteArea.Buttons => Buttons;
            IntPtr PlayerVoteArea.PlayerIcon => PlayerIcon;
            IntPtr PlayerVoteArea.Background => Background;
            IntPtr PlayerVoteArea.Flag => Flag;
            IntPtr PlayerVoteArea.Megaphone => Megaphone;
            IntPtr PlayerVoteArea.Overlay => Overlay;
            IntPtr PlayerVoteArea.NameText => NameText;
            bool PlayerVoteArea.isDead => isDead;
            bool PlayerVoteArea.didVote { get { return votedFor != -1 && votedFor != -2; } }
            bool PlayerVoteArea.didReport => didReport;
            sbyte PlayerVoteArea.votedFor => votedFor;
            bool PlayerVoteArea.voteComplete => voteComplete;
            bool PlayerVoteArea.resultsShowing => resultsShowing;
        }
    }

    static partial class Struct_2021_6_30s
    {
        [StructLayout(LayoutKind.Explicit)]
        public struct v_PlayerVoteArea : PlayerVoteArea
        {
            [FieldOffset(0x08)] public IntPtr m_CachedPtr;
            [FieldOffset(0x10)] public sbyte Id_;
            [FieldOffset(0x14)] public IntPtr Buttons;
            [FieldOffset(0x18)] public IntPtr ConfirmButton;
            [FieldOffset(0x1C)] public IntPtr CancelButton;
            [FieldOffset(0x20)] public IntPtr PlayerButton;
            [FieldOffset(0x24)] public IntPtr PlayerIcon;
            [FieldOffset(0x28)] public IntPtr Background;
            [FieldOffset(0x2C)] public IntPtr Flag;
            [FieldOffset(0x30)] public IntPtr Megaphone;
            [FieldOffset(0x34)] public IntPtr Overlay;
            [FieldOffset(0x38)] public IntPtr XMark;
            [FieldOffset(0x3C)] public IntPtr NameText;
            [FieldOffset(0x40)] public IntPtr SkipVoteText;
            [FieldOffset(0x44)] public IntPtr PlatformIcon;
            [FieldOffset(0x48)] public bool AnimateButtonFromLeft;
            [FieldOffset(0x49)] public bool isDead;
            [FieldOffset(0x4a)] public bool didReport;
            [FieldOffset(0x4b)] public sbyte votedFor;
            [FieldOffset(0x4c)] public bool voteComplete;
            [FieldOffset(0x4d)] public bool resultsShowing;

            IntPtr PlayerVoteArea.m_CachedPtr => m_CachedPtr;
            sbyte PlayerVoteArea.Id_ => Id_;
            IntPtr PlayerVoteArea.Buttons => Buttons;
            IntPtr PlayerVoteArea.PlayerIcon => PlayerIcon;
            IntPtr PlayerVoteArea.Background => Background;
            IntPtr PlayerVoteArea.Flag => Flag;
            IntPtr PlayerVoteArea.Megaphone => Megaphone;
            IntPtr PlayerVoteArea.Overlay => Overlay;
            IntPtr PlayerVoteArea.NameText => NameText;
            bool PlayerVoteArea.isDead => isDead;
            bool PlayerVoteArea.didVote { get { return votedFor != -1 && votedFor != -2; } }
            bool PlayerVoteArea.didReport => didReport;
            sbyte PlayerVoteArea.votedFor => votedFor;
            bool PlayerVoteArea.voteComplete => voteComplete;
            bool PlayerVoteArea.resultsShowing => resultsShowing;
        }
    }
    */
}
